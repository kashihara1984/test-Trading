using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ClipBoardTest.Common
{
    public class DBManager:IDisposable
    {
        private string connection_str;
        SqlConnection conn;
        SqlTransaction trans = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBManager()
        {
            // データベース接続用文字列の作成
            // Web.Configからとる
            connection_str = ConfigurationManager.ConnectionStrings["CBConnectionString"].ConnectionString;
            conn = new SqlConnection(connection_str);
            conn.Open();
        }

        /// <summary>
        /// 破棄するﾒｿｯﾄﾞ
        /// </summary>
        public void Dispose()
        {
            conn.Close();
        }


        /// <summary>
        /// テーブル更新
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public void WriteTable(string str, 
            　　　　　　　　　 List<SqlParameter> paramList = null)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    //トランザクションの使用により処理を分ける
                    if (trans != null)
                    {
                        cmd.Transaction = trans;
                    }
                    cmd.CommandText = str;
                    // 今回は全てストアド処理にする
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (paramList != null)
                    {
                        foreach (var paramItem in paramList)
                        {
                            cmd.Parameters.Add(paramItem);
                        }
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// テーブル参照
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable ReadTable(string str, List<SqlParameter> paramList = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    // 今回は全てストアド処理にする
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (paramList != null)
                    {
                        foreach (var paramItem in paramList)
                        {
                            cmd.Parameters.Add(paramItem);
                        }
                    }
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    cmd.Dispose();

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTrans() 
        {
            trans = conn.BeginTransaction();
        }

        /// <summary>
        /// コミット
        /// </summary>
        public void Commit() 
        {
            trans.Commit();
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public void RollBack() 
        {
            trans.Rollback();
        }

        
    }
}