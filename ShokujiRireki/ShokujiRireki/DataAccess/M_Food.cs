using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ShokujiRireki.Common;
using ShokujiRireki.DataAccess;
using System.Windows.Forms;


namespace ShokujiRireki.DataAccess
{
    class M_Food
    {
        private const string MAIN_MAXNO = @"SELECT 
                                                                   MAX(No) 
                                                                 FROM
                                                                   M_FOOD";
        private const string Main_RankFood = @"SELECT
                                                                      RTRIM(FOODNAME)
                                                                    FROM
                                                                      M_FOOD
                                                                    WHERE No = @No";
        public const string Food_cmb = @"SELECT
                                                                No,
                                                                FoodName
                                                             FROM
                                                                M_FOOD
                                                             WHERE
                                                                DELFLG = @DelFlg";
        public const string Master = @"SELECT 
                                                        No,
                                                        FoodName,
                                                        CAL,
                                                        DELFLG
                                                      FROM
                                                        M_FOOD
                                                      WHERE DELFLG = 0";
        public const string Master_Add = @"INSERT
                                                               M_FOOD
                                                                (FoodName,
                                                                 CAL,
                                                                 DELFLG)
                                                             VALUES
                                                                (@FoodName,
                                                                  @Cal,
                                                                  @Delflg)";
        public const string Master_UpdateCal = @"UPDATE
                                                                         M_FOOD
                                                                       SET
                                                                         CAL = @CAL 
                                                                       WHERE
                                                                         No = @No";

        public const string Master_Del = @"UPDATE 
                                                               M_FOOD
                                                             SET
                                                               DELFLG = 1
                                                             WHERE No = @No";


        #region メイン画面
        //食べた回数の多いものを表示
          //食品コードの最大値を取得
        public int MaxNo()
        {
            int num;
            num = (int)GetData(MAIN_MAXNO, null);
            return num;
        }

          //食品コードから食品名を返す
        public string GetFoodName(string code)
        {
            SqlParameter rank = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();
            rank.ParameterName = Const.PARM_NO;
            rank.Value = code;
            rank.SqlDbType = SqlDbType.NChar;
            parms.Add(rank);
            string name;
            name = GetData(Main_RankFood, parms).ToString();
            return name;
        }
        #endregion

        #region 新規登録画面
        //コンボボックス名を引数とし、コンボボックスの設定も行う
        public void GetFoodcmb(ComboBox cmb)
        {
            List<SqlParameter> parms = new List<SqlParameter>();
            SqlParameter delflg = new SqlParameter();
            delflg.ParameterName = Const.PARM_DELFLG;
            delflg.Value = 0;
            delflg.SqlDbType = SqlDbType.NVarChar;
            parms.Add(delflg);

            cmb.DataSource = GetDataTable(Food_cmb, parms);
            cmb.DisplayMember = "FoodName";
            cmb.ValueMember = "No";
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = -1;
        }

        #endregion

        //マスタ編集画面
            //テーブルの表示
        public DataTable GetMaster()
        {
            DataTable dtMaster = new DataTable();
            dtMaster = GetDataTable(Master, null);
            return dtMaster;
        }
            //追加処理
        public void InsertMaster(TextBox name,TextBox cal)
        {
            DBmanager objDBM = DBmanager.CreateInstance();
            M_Food objFood = new M_Food();
            SqlParameter Foodparm = new SqlParameter();
            SqlParameter Calparm = new SqlParameter();
            SqlParameter Delflgparm = new SqlParameter();
            List<SqlParameter> parms = new List<SqlParameter>();

            Foodparm.ParameterName = Const.PARM_FOODNAME;
            Foodparm.Value = name.Text;
            Foodparm.SqlDbType = SqlDbType.NChar;

            Calparm.ParameterName = Const.PARM_CAL;
            Calparm.Value = cal.Text;
            Calparm.SqlDbType = SqlDbType.Int;

            Delflgparm.ParameterName = Const.PARM_DELFLG;
            Delflgparm.Value = "0";
            Delflgparm.SqlDbType = SqlDbType.NChar;

            parms.Add(Foodparm);
            parms.Add(Calparm);
            parms.Add(Delflgparm);
            objDBM.BeginTrans();
            try
            {
                objFood.RunSql(Master_Add, parms);
                objDBM.CommitTrans();
                MessageBox.Show("追加しました");
            }
            catch(Exception ex)
            {
                objDBM.RollbackTrans();
                throw ex;
            }
        }
            //マスタの更新
        public void UpdateMaster(DataRow[] updateRows)
        {
            DBmanager objDBM = DBmanager.CreateInstance();
            M_Food objFood = new M_Food();
            objDBM.BeginTrans();
            try
            {
                for (int i = 0; i < updateRows.Length; i++)
                {
                    SqlParameter Calparm = new SqlParameter();
                    SqlParameter Noparm = new SqlParameter();
                    List<SqlParameter> parms = new List<SqlParameter>();
                    Calparm.ParameterName = Const.PARM_CAL;
                    Calparm.Value = (int)updateRows[i]["CAL"];
                    Calparm.SqlDbType = SqlDbType.Int;
                    Noparm.ParameterName = Const.PARM_NO;
                    Noparm.Value = updateRows[i]["No"];
                    Noparm.SqlDbType = SqlDbType.NChar;
                    parms.Add(Calparm);
                    parms.Add(Noparm);
                    objFood.RunSql(Master_UpdateCal, parms);
                }
                objDBM.CommitTrans();
                MessageBox.Show("更新しました");
            }
            catch(Exception ex)
            {
                objDBM.RollbackTrans();
                throw ex;
            }

            
        }
                //データグリッドビュー上の削除ボタン押下（非表示にする）
        public void DeleteFood(int foodNo)
        {
            SqlParameter KeyFood = new SqlParameter();

            List<SqlParameter> parms = new List<SqlParameter>();
            KeyFood.ParameterName = Const.PARM_NO;
            KeyFood.Value = foodNo;
            KeyFood.SqlDbType = SqlDbType.Int;

            parms.Add(KeyFood);
            DBmanager objDBM = DBmanager.CreateInstance();
            objDBM.BeginTrans();
            try
            {
                RunSql(Master_Del, parms);
                objDBM.CommitTrans();
                MessageBox.Show("削除しました");
            }
            catch(Exception ex)
            {
                objDBM.RollbackTrans();
                throw ex;
            }
        }


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


        //１つのみのデータテーブルの値を取得(戻り値はobject型なので型の変換が必要)
        //取得するデータが文字列のものと数字のものがあるので戻り値はobject型
        public object GetData(string strsql, List<SqlParameter> parms)
        {
            object obj;
            DBmanager objDBM = DBmanager.CreateInstance();
            using (SqlCommand objcmd = new SqlCommand())
            {
                //objcmd.Connection = _connection;
                objcmd.Connection = objDBM.connection;
                objcmd.CommandText = strsql;
                if (parms != null)
                {
                    foreach (SqlParameter parm in parms)
                    {
                        objcmd.Parameters.Add(parm);
                    }
                }
                obj = objcmd.ExecuteScalar();

                if (parms != null)
                {
                    objcmd.Parameters.Clear();
                    parms.Clear();
                }
            }
            return obj;
        }
        #endregion


    }
}
