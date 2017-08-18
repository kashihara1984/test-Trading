using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ShokujiRireki
{
    class DBmanager
    {
        private static DBmanager objDBM;

        private DBmanager()
        {
        }

        

        public static DBmanager CreateInstance()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            if (objDBM == null)
            {
                objDBM = new DBmanager();
                objDBM.connectionstring = connection;
                objDBM.DBConnect();
            }
            return objDBM;
        }

        //接続文字列


        private string _connectionstring;
        public string connectionstring
        {
            get { return _connectionstring; }
            set { _connectionstring = value; }
        }



        //ADOコネクションオブジェクト
        //private SqlConnection _connection;

        private SqlConnection _connection;
        public SqlConnection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }
        


        //接続メソッド
        private void DBConnect()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = _connectionstring;
            _connection.Open();
        }

        //private SqlTransaction objTrans = null;
        private SqlTransaction _objTrans = null;
        public SqlTransaction objTrans
        {
            get { return _objTrans ; }
            set { _objTrans =  value; }
        }
        
        
        public SqlTransaction DBTransaction
        {
            get 
            {
                return objTrans;
            }            
        }

        //切断メソッド
        public void DisDBconnect()
        {
            _connection.Close();
            _connection.Dispose();
        }

        //トランザクション開始メソッド
        public void BeginTrans()
        {
            objTrans = _connection.BeginTransaction();
        }

        //トランザクション確定メソッド
        public void CommitTrans()
        {
            objTrans.Commit();
            objTrans = null;
        }

        //ロールバックメソッド
        public void RollbackTrans()
        {
            objTrans.Rollback();
            objTrans = null;
        }

        ////自作関数

        //public DataTable getDataTable(string strsql, List<SqlParameter> parms)
        //{
        //    DataTable dtTable = new DataTable();
        //    using(SqlCommand objcmd = new SqlCommand()){
        //        objcmd.Connection = _connection;
        //        objcmd.CommandText = strsql;
        //        if (parms != null)
        //        {
        //            foreach (SqlParameter parm in parms)
        //            {
        //                objcmd.Parameters.Add(parm);
        //            }
        //        }
        //        using(SqlDataAdapter objadpt = new SqlDataAdapter())
        //        {
        //            objadpt.SelectCommand = objcmd;
        //            objadpt.Fill(dtTable);
        //        }
        //        if (parms != null)
        //        {
        //            objcmd.Parameters.Clear();
        //            parms.Clear();
        //        }
        //    }
        //    return dtTable;
        //}

        ////更新系
        //public int RunSql(string strsql, List<SqlParameter> parms)
        //{
        //    int count = 0;
        //    using (SqlCommand objcmd = new SqlCommand())
        //    {
                
        //        objcmd.Connection = _connection;
        //        objcmd.Transaction = objTrans;
        //        if (parms != null)
        //        {
        //            foreach (SqlParameter parm in parms)
        //            {
        //                objcmd.Parameters.Add(parm);
        //            }
        //        }
        //        objcmd.CommandText = strsql;

        //        objcmd.ExecuteNonQuery();


        //        //パラメータのクリア
        //        if (parms != null)
        //        {
        //            objcmd.Parameters.Clear();
        //            parms.Clear();
        //        }
        //    }
        //    return count;
        //}



    }
}
