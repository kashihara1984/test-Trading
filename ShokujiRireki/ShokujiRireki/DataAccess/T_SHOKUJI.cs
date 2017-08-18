using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ShokujiRireki.DataAccess;
using ShokujiRireki.Common;
using System.Windows.Forms;

namespace ShokujiRireki.DataAccess
{
    //SQL文が宣言されているクラス
    class T_SHOKUJI
    {

        //テーブルごとにクラスを1つづつ作る
        //T_SHOKUJI・M_Food M_USER

        //トランザクション処理もこのクラス内で行う
        //GetDataTableで取得したデータテーブルはpublicで宣言し他のクラスから参照できるようにする

        //このクラス内で処理を行うので定数を他のクラスから呼び出さず、このクラスで処理したものを返すようにするので
        //SQL文は全てprivateになる


        //T_SHOKUJI
        private const string MAIN = @"SELECT 
                                                             T.DATE,
                                                              SUBSTRING(T.DATE,1,4) + '年' 
                                                           + SUBSTRING(T.DATE,5,2) + '月'
                                                           + SUBSTRING(T.DATE,7,2) + '日'
                                                              as 日付,
                                                              B.FoodName as 朝食,
                                                              L.FoodName as 昼食,
                                                              D.FoodName as 夕食,
                                                              B.CAL + L.CAL + D.CAL
                                                              as '1日のカロリー摂取量'
                                                            FROM T_SHOKUJI as T
                                                            LEFT JOIN M_FOOD as D
                                                              on D.No = T.DINNER
                                                            LEFT JOIN M_FOOD as L
                                                              on L.No = T.LUNCH
                                                            LEFT JOIN M_FOOD as B
                                                              on B.No = T.BREAKFAST ";
        private const string MAIN_DATE = @"ORDER
                                                                  BY T.DATE";
        private const string MAIN_CAL = @"ORDER 
                                                                  BY B.CAL 
                                                                    + L.CAL
                                                                    + D.CAL DESC";
        private const string MAIN_KIKAN = @"WHERE
                                                                    T.DATE
                                                                 BETWEEN 
                                                                    @strFrom
                                                                 AND
                                                                    @strTO";


        private const string Main_CountBreakfast = @"SELECT
                                                                             COUNT(BREAKFAST)
                                                                           FROM 
                                                                             T_SHOKUJI 
                                                                           WHERE BREAKFAST = @No";
        private const string Main_CountLunch = @"SELECT
                                                                        COUNT(LUNCH)
                                                                      FROM
                                                                        T_SHOKUJI
                                                                      WHERE LUNCH = @No";
        private const string Main_CountDinner = @"SELECT
                                                                         COUNT(DINNER)
                                                                       FROM
                                                                         T_SHOKUJI
                                                                       WHERE DINNER = @No";



        private const string Registry_CheckKeyDate = @"SELECT
                                                                                 COUNT(*)
                                                                               FROM
                                                                                 T_SHOKUJI
                                                                               WHERE
                                                                                 DATE = @DATE";


        private const string Registry_Insert = @"INSERT
                                                                    T_SHOKUJI
                                                                     (DATE ,
                                                                      BREAKFAST ,
                                                                      LUNCH ,
                                                                      DINNER ,
                                                                      DELFLG)
                                                                  VALUES
                                                                     (@Date,
                                                                      @Breakfast,
                                                                      @Lunch,
                                                                      @Dinner,
                                                                      @Delflg)";


        private const string Detail_Update = @"UPDATE
                                                                    T_SHOKUJI
                                                                  SET
                                                                    BREAKFAST = @Breakfast,
                                                                    LUNCH = @Lunch,
                                                                    DINNER = @Dinner
                                                                  Where DATE = @Date";


        #region メイン画面
        //メイン画面の表示
        public DataTable dtMain = new DataTable();
            //日付順
        public DataTable GetTablebyDate()
        {
            dtMain = GetDataTable(MAIN + MAIN_DATE, null);
            return dtMain;
        }

        //指定した期間
        public DataTable GetTablebyKikan(string strFrom,string strTo)
        {
            SqlParameter parmFrom = new SqlParameter();
            SqlParameter parmTo = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();

            parmFrom.ParameterName = Const.PARM_STRFROM;
            parmFrom.Value = strFrom;
            parmFrom.SqlDbType = SqlDbType.NChar;

            parmTo.ParameterName = Const.PARM_STRTO;
            parmTo.Value = strTo;
            parmTo.SqlDbType = SqlDbType.NChar;

            parms.Add(parmFrom);
            parms.Add(parmTo);

            dtMain = GetDataTable(MAIN + MAIN_KIKAN, parms);
            return dtMain;
        }
        
            //1日のカロリー量の多い順
        public DataTable GetTablebyCal()
        {
            dtMain = GetDataTable(MAIN + MAIN_CAL, null);
            return dtMain;
        }

            //各食事ごとに項目の回数を算出する
        public int CountBreakfast(int No)
        {
            int num ;
            SqlParameter parmNum = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();
            parmNum.ParameterName = Const.PARM_NO;
            parmNum.Value = No;
            parmNum.SqlDbType = SqlDbType.NChar;
            parms.Add(parmNum);

            num = GetDataCount(Main_CountBreakfast, parms);
            return num;
        }

        public int CountLunch(int No)
        {
            int num;
            SqlParameter parmNum = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();
            parmNum.ParameterName = Const.PARM_NO;
            parmNum.Value = No;
            parmNum.SqlDbType = SqlDbType.NChar;
            parms.Add(parmNum);

            num = GetDataCount(Main_CountLunch, parms);
            return num;
        }

        public int CountDinner(int No)
        {
            int num;
            SqlParameter parmNum = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();
            parmNum.ParameterName = Const.PARM_NO;
            parmNum.Value = No;
            parmNum.SqlDbType = SqlDbType.NChar;
            parms.Add(parmNum);

            num = GetDataCount(Main_CountDinner, parms);
            return num;
        }
        #endregion

        #region 新規登録画面
        //日付の重複チェック
        public int CheckKeyDate(string date)
        {
            int num;
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter dateparm = new SqlParameter();
            dateparm.ParameterName = Const.PARM_DATE;
            dateparm.Value = date;
            dateparm.SqlDbType = SqlDbType.NChar;
            parms.Add(dateparm);
            num = GetDataCount(Registry_CheckKeyDate, parms);
            return num;
        }
        //新規登録
        public void Registry(string hiduke,ComboBox cmbBreakfast,ComboBox cmbLunch,ComboBox cmbDinner)
        {
            DBmanager objDBM = DBmanager.CreateInstance();
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter date = new SqlParameter();
            SqlParameter breakfast = new SqlParameter();
            SqlParameter lunch = new SqlParameter();
            SqlParameter dinner = new SqlParameter();
            SqlParameter delflg = new SqlParameter();

            date.ParameterName = Const.PARM_DATE;
            date.Value = hiduke;
            date.SqlDbType = SqlDbType.NChar;

            breakfast.ParameterName = Const.PARM_BREAKFAST;
            breakfast.Value = cmbBreakfast.SelectedValue;
            breakfast.SqlDbType = SqlDbType.NChar;

            lunch.ParameterName = Const.PARM_LUNCH;
            lunch.Value = cmbLunch.SelectedValue;
            lunch.SqlDbType = SqlDbType.NChar;

            dinner.ParameterName = Const.PARM_DINNER;
            dinner.Value = cmbDinner.SelectedValue;
            dinner.SqlDbType = SqlDbType.NChar;

            delflg.ParameterName = "@Delflg";
            delflg.Value = "0";
            delflg.SqlDbType = SqlDbType.NChar;
            parms.Add(date);
            parms.Add(breakfast);
            parms.Add(lunch);
            parms.Add(dinner);
            parms.Add(delflg);

            objDBM.BeginTrans();
            try
            {
                RunSql(Registry_Insert, parms);
                objDBM.CommitTrans();
                MessageBox.Show("登録しました");
            }
            catch (Exception ex)
            {
                objDBM.RollbackTrans();
                throw ex;
            }
        }
        
        #endregion


        #region 更新画面

        public void Update(string hiduke, ComboBox cmbBreakfast, ComboBox cmbLunch, ComboBox cmbDinner)
        {
            DBmanager objDBM = DBmanager.CreateInstance();
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter date = new SqlParameter();
            SqlParameter breakfast = new SqlParameter();
            SqlParameter lunch = new SqlParameter();
            SqlParameter dinner = new SqlParameter();

            date.ParameterName = Const.PARM_DATE;
            date.Value = hiduke;
            date.SqlDbType = SqlDbType.NChar;

            breakfast.ParameterName = Const.PARM_BREAKFAST;
            breakfast.Value = cmbBreakfast.SelectedValue;
            breakfast.SqlDbType = SqlDbType.NChar;

            lunch.ParameterName = Const.PARM_LUNCH;
            lunch.Value = cmbLunch.SelectedValue;
            lunch.SqlDbType = SqlDbType.NChar;

            dinner.ParameterName = Const.PARM_DINNER;
            dinner.Value = cmbDinner.SelectedValue;
            dinner.SqlDbType = SqlDbType.NChar;

            parms.Add(date);
            parms.Add(breakfast);
            parms.Add(lunch);
            parms.Add(dinner);

            objDBM.BeginTrans();
            try
            {
                RunSql(Detail_Update, parms);
                objDBM.CommitTrans();
                MessageBox.Show("更新しました");
            }
            catch(Exception ex)
            {
                objDBM.RollbackTrans();
                throw ex;
            }
        }

        #endregion



        #region 自作関数

        public DataTable GetDataTable(string strsql, List<SqlParameter> parms)
        {
            DataTable dtTable = new DataTable();
            DBmanager objDBM = DBmanager.CreateInstance();
            using (SqlCommand objcmd = new SqlCommand())
            {
                objcmd.Connection = objDBM.connection;
                objcmd.CommandText = strsql;
                if (parms != null)
                {
                    foreach (SqlParameter parm in parms)
                    {
                        objcmd.Parameters.Add(parm);
                    }
                }
                using (SqlDataAdapter objadpt = new SqlDataAdapter())
                {
                    objadpt.SelectCommand = objcmd;
                    objadpt.Fill(dtTable);
                }
                if (parms != null)
                {
                    objcmd.Parameters.Clear();
                    parms.Clear();
                }
            }
            return dtTable;
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


        //１つのみのデータテーブルの値を取得(戻り値はint型)
        public int GetDataCount(string strsql, List<SqlParameter> parms)
        {
            int num;
            DBmanager objDBM = DBmanager.CreateInstance();
            using (SqlCommand objcmd = new SqlCommand())
            {
                objcmd.Connection = objDBM.connection;
                objcmd.CommandText = strsql;
                if (parms != null)
                {
                    foreach (SqlParameter parm in parms)
                    {
                        objcmd.Parameters.Add(parm);
                    }
                }
                num = (int)objcmd.ExecuteScalar();
                if (parms != null)
                {
                    objcmd.Parameters.Clear();
                    parms.Clear();
                }
            }
            return num;
        }
        #endregion




    }
}
