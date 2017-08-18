using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShokujiRireki.Common;
using ShokujiRireki.DataAccess;
using System.Windows.Forms;

namespace ShokujiRireki.DataAccess
{
    class M_USER
    {
        public const string USER_COUNT = @"SELECT
                                                                   COUNT(*)
                                                                 FROM
                                                                   M_USER
                                                                 WHERE USERID = @User";
        public const string USER_NOT_LOCKED_COUNT = @" AND
                                                                                          LOCKFLG = 0";
        public const string USER_LOGIN_COUNT = @" AND 
                                                                               PASSWD = @Password";
        public const string LOCK_USER = @" UPDATE 
                                                                 M_USER 
                                                               SET
                                                                 LOCKFLG = '1' 
                                                               WHERE
                                                                 USERID = @User";
        //入力したユーザー名と一致する数を返す
        public int GetUserCount(string username)
        {
            int num;
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter userparm = new SqlParameter();
            userparm.ParameterName = Const.PARM_USER;
            userparm.Value = username;
            userparm.SqlDbType = SqlDbType.NChar;
            parms.Add(userparm);
            num = getCount(USER_COUNT, parms);            
            return num;
        }
        //さらにロックのかけられていないユーザー数を返す
        public int GetNoLockedUserCount(string username)
        {
            int num;
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter userparm = new SqlParameter();
            userparm.ParameterName = Const.PARM_USER;
            userparm.Value = username;
            userparm.SqlDbType = SqlDbType.NChar;
            parms.Add(userparm);
            num = getCount(USER_COUNT + USER_NOT_LOCKED_COUNT, parms);
            return num;
        }

        //さらにパスワードの一致するユーザー数を返す
        public int GetLoginUserCount(string username,string password)
        {
            int num;
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter userparm = new SqlParameter();
            SqlParameter passparm = new SqlParameter();
            userparm.ParameterName = Const.PARM_USER;
            userparm.Value = username;
            userparm.SqlDbType = SqlDbType.NChar;
            passparm.ParameterName = Const.PARM_PASSWORD;
            passparm.Value = password;
            passparm.SqlDbType = SqlDbType.NChar;
            parms.Add(userparm);
            parms.Add(passparm);
            num = getCount(USER_COUNT + USER_NOT_LOCKED_COUNT + USER_LOGIN_COUNT, parms);
            return num;
        }

        //ロック処理
        public void LockUser(string username)
        {
            DBmanager objDBM = DBmanager.CreateInstance();            
            SqlParameter userparm = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();
            userparm.ParameterName = Const.PARM_USER;
            userparm.Value = username;
            userparm.SqlDbType = SqlDbType.NChar;
            parms.Add(userparm);
            objDBM.BeginTrans();
            try
            {
                RunSql(LOCK_USER, parms);
                objDBM.CommitTrans();
                MessageBox.Show(Const.LOCK_USER);
            }
            catch(Exception ex)
            {
                objDBM.RollbackTrans();
                //呼び出し元の処理に戻る
                throw ex;
            }
        }
        
        //１つのみのデータテーブルの値を取得(戻り値はint型)
        public int getCount(string sql, List<SqlParameter>parms)
        {
            int num;
            DBmanager objDBM = DBmanager.CreateInstance();

            using (SqlCommand objcmd = new SqlCommand())
            {
                //objcmd.Connection = _connection;
                objcmd.Connection = objDBM.connection;
                objcmd.CommandText = sql;
                if (parms != null)
                {
                    foreach (SqlParameter parm in parms)
                    {
                        objcmd.Parameters.Add(parm);
                    }                    
                }
                //obj =(int) objcmd.ExecuteScalar();
                num = (int)objcmd.ExecuteScalar();
                if (parms != null)
                {
                        objcmd.Parameters.Clear();
                        parms.Clear();
                }
            }
            return num;
        }

        //更新系
        public int RunSql(string strsql, List<SqlParameter> parms)
        {
            int count = 0;
            DBmanager objDBM = DBmanager.CreateInstance();
            using (SqlCommand objcmd = new SqlCommand())
            {

                //objcmd.Connection = _connection;
                objcmd.Connection = objDBM.connection;

                //objcmd.Transaction = objTrans;
                objcmd.Transaction = objDBM.objTrans;
                if (parms != null)
                {
                    foreach (SqlParameter parm in parms)
                    {
                        objcmd.Parameters.Add(parm);
                    }
                }
                objcmd.CommandText = strsql;

                objcmd.ExecuteNonQuery();


                //パラメータのクリア
                if (parms != null)
                {
                    objcmd.Parameters.Clear();
                    parms.Clear();
                }
            }
            return count;
        }



    }
}
