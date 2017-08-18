using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KyabusuC.DataAceess
{
    public class T_Login
    {
        //ログインデータテーブル
        DataTable L_dt = new DataTable();
        //ログインデータテーブルを二通りで取得
        public T_Login(int TwoWays, string userID, string pass)
        {
            if (TwoWays == 1)
            {
                DBmanager DuplicationCheck = DBmanager.CreateInstance();

                string sql = @"select
                                UserID 
                               from
                                Login
                               where 
                                UserID = @UserID 
                               and 
                                PassWD = @Pass";

                SqlParameter D_UserID = new SqlParameter("@UserID", userID);
                SqlParameter D_Pass = new SqlParameter("@Pass", pass);
                List<SqlParameter> D_paras = new List<SqlParameter>();
                D_paras.Add(D_UserID);
                D_paras.Add(D_Pass);
                L_dt = DuplicationCheck.get(sql, D_paras);
                CL_dt = L_dt;
            }
            else if (TwoWays == 2)
            {
                DBmanager LockCheck = DBmanager.CreateInstance();
                
                string  sql = @"select 
                                 Lock
                                from 
                                 Login
                                where
                                 UserID = @UserID 
                                and 
                                 PassWD = @Pass";
                SqlParameter L_UserID = new SqlParameter("@UserID", userID);
                SqlParameter L_Pass = new SqlParameter("@Pass", pass);
                List<SqlParameter> L_paras = new List<SqlParameter>();
                L_paras.Add(L_UserID);
                L_paras.Add(L_Pass);
                L_dt = LockCheck.get(sql, L_paras);
                CL_dt = L_dt;
            }
        }
           //L_dt取得・設定プロパティ
        public DataTable CL_dt { get; set; }
    }
    
}
