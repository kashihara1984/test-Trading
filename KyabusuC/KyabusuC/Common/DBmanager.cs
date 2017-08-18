using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace KyabusuC
{
    
        public class DBmanager: IDisposable
    {
        //newできない
        private DBmanager() { }

        private static DBmanager objDBmanager;

        
        //メソッドやプロパティの実装
        public static DBmanager CreateInstance()
        {
             if (objDBmanager == null)
            {
                objDBmanager = new KyabusuC.DBmanager();
                objDBmanager.ConnectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
                objDBmanager.DbCount();
            }
             return objDBmanager;
         }
        //接続パスワードを格納
        public string  ConnectionString { get; set; }
        //sqlコネクションの作成
        private SqlConnection cone = new SqlConnection();
        //接続の継続
        private void DbCount(string pro = null)
        {
            cone.ConnectionString =ConnectionString;
            cone.Open();
        }
        //DB切断メソッド
        private void DisDbCount()
        {
            cone.Close();
            cone.Dispose();
        }
        //トランザクトオブジェクト
        private SqlTransaction objTrans = null;
        

        public  SqlTransaction DbmTransaction
        {
            get { return objTrans; }
           
        }

        //トランザクション開始
        public void BeginTrans()
        {
            
            objTrans = cone.BeginTransaction(IsolationLevel.ReadCommitted);
        }
        //トランザクション確定メソッド
        public void CommitTrans()
        {
            objTrans.Commit();
            objTrans = null;
        }
        //トランザクション破棄メソッド
        public void RollbackTrans()
        {
            objTrans.Rollback();
            objTrans = null;

        }

        //テーブルのデータ取得
        public  DataTable get (string sql,List<SqlParameter> para)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = cone;
            com.Transaction = objTrans;
            com.CommandText = sql;
            if (para != null)
            {
                foreach (SqlParameter param in para)
                {
                    com.Parameters.Add(param);
                }
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter();
            adapt.SelectCommand = com;
            adapt.Fill(dt);


            return dt ;
         }
        //登録・更新・削除
        public void  Execution(string sql, List<SqlParameter> para)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = cone;
            com.Transaction = objTrans;
            com.CommandText = sql;
            if (para != null)
            {
                foreach (SqlParameter param in para)
                {
                    com.Parameters.Add(param);
                }
            }
            com.ExecuteNonQuery();


            
        }

        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                    this.DisDbCount();
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

                disposedValue = true;
            }
        }

        // TODO: 上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        // ~DBmanager() {
        //   // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //   Dispose(false);
        // }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    
}
