using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShokujiRireki.Common;
using ShokujiRireki.DataAccess;
using System.Data.SqlClient;
namespace ShokujiRireki
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        #region フォームロード

        private void Main_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            //データグリッドビューのプロパティー
            dgv_Shokuji.ReadOnly = true;
            dgv_Shokuji.RowHeadersVisible = false;
            dgv_Shokuji.AllowUserToAddRows = false;
            dgv_Shokuji.AllowUserToDeleteRows = false;
            dgv_Shokuji.AllowUserToResizeColumns = false;
            dgv_Shokuji.AllowUserToResizeRows = false;
            dgv_Shokuji.AutoGenerateColumns = false;
            dgv_Shokuji.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DataGridViewTextBoxColumn objDate = new DataGridViewTextBoxColumn();
            objDate.HeaderText = Const.COL_DATE;
            objDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            objDate.DataPropertyName = Const.COL_DATE;
            dgv_Shokuji.Columns.Add(objDate);

            DataGridViewTextBoxColumn objBreakfast = new DataGridViewTextBoxColumn();
            objBreakfast.HeaderText = Const.COL_BREAKFAST;
            objBreakfast.SortMode = DataGridViewColumnSortMode.NotSortable;
            objBreakfast.DataPropertyName = Const.COL_BREAKFAST;
            dgv_Shokuji.Columns.Add(objBreakfast);

            DataGridViewTextBoxColumn objLunch = new DataGridViewTextBoxColumn();
            objLunch.HeaderText = Const.COL_LUNCH;
            objLunch.SortMode = DataGridViewColumnSortMode.NotSortable;
            objLunch.DataPropertyName = Const.COL_LUNCH;
            dgv_Shokuji.Columns.Add(objLunch);

            DataGridViewTextBoxColumn objDinner = new DataGridViewTextBoxColumn();
            objDinner.HeaderText = Const.COL_DINNER;
            objDinner.SortMode = DataGridViewColumnSortMode.NotSortable;
            objDinner.DataPropertyName = Const.COL_DINNER;
            dgv_Shokuji.Columns.Add(objDinner);

            DataGridViewTextBoxColumn objCal = new DataGridViewTextBoxColumn();
            objCal.HeaderText = Const.COL_TOTAL_CAL;
            objCal.SortMode = DataGridViewColumnSortMode.NotSortable;
            objCal.DataPropertyName = Const.COL_TOTAL_CAL;
            dgv_Shokuji.Columns.Add(objCal);

            
            T_SHOKUJI objShokuji = new T_SHOKUJI();
            try
            {
                dgv_Shokuji.DataSource = objShokuji.GetTablebyDate();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(Const.ERROR);
                return;
            }
            


            //コンボボックスの設定
            DateTime dtNow = DateTime.Now;
            for(int i=2000;i<=dtNow.Year;i++)
            {
                cmbFromY.Items.Add(i);
                cmbToY.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cmbFromM.Items.Add("0" + i);
                    cmbToM.Items.Add("0" + i);
                }
                else
                {
                    cmbFromM.Items.Add(i);
                    cmbToM.Items.Add(i);
                }
            }
            cmbFromY.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFromM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToY.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToM.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion


        #region 閉じるボタン

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Const.CLOSE_APPLICATION,
                                            "終了確認",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else
            {
                DBmanager objDBM = DBmanager.CreateInstance();
                objDBM.DisDBconnect();
                Login.LoginForm.Close();
            }
        }
        #endregion

        #region 新規登録ボタン

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registry objReg = new Registry();
            objReg.StartPosition = FormStartPosition.CenterScreen;
            objReg.Show();
            this.Close();
        }
        #endregion


        //検索ボタン
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBmanager objDBM = DBmanager.CreateInstance();

            #region 指定した期間で検索を行うが選択されたとき
            if (rdoKikan.Checked)
            {
                string strFrom = cmbFromY.Text + cmbFromM.Text;
                string strTo = cmbToY.Text + cmbToM.Text;
                string strWk = strFrom + strTo;
                //期間検索は全てのコンボボックスが入力されたときのみ
                if (strWk.Length != 12)
                {
                    MessageBox.Show(Const.CHECK_CMB);
                    return;
                }

                //コンボボックスから選択した値しか選択できないのでこの処理は不要
                //if (!int.TryParse(strFrom, out intFrom) || !int.TryParse(strTo, out intTo))
                //{
                //    MessageBox.Show(Const.CHECK_CMBMOJI);
                //    return;
                //}

                //　From<=To
                if (int.Parse(strFrom)> int.Parse(strTo))
                {
                    MessageBox.Show(Const.CHECK_CMBKIKAN);
                    return;
                }

                strFrom += "01";
                //Toの年と月から月末の日付を取得
                int lastday = DateTime.DaysInMonth(int.Parse(cmbToY.Text), int.Parse(cmbToM.Text));
                strTo += lastday;

                T_SHOKUJI objSQL = new T_SHOKUJI();
                try
                {
                    dgv_Shokuji.DataSource = objSQL.GetTablebyKikan(strFrom, strTo);
                }
                catch(SqlException sqlex)
                {
                    MessageBox.Show(Const.DATABASE_ERROR);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Const.ERROR);
                    return;
                }
            }
            #endregion


            #region 食べた回数の多いもの上位3つを表示するが選択されたとき

            if (rdoRank.Checked)
            {
                M_Food objFood = new M_Food();
                int maxNo = objFood.MaxNo();
                int countBreakfast;
                int countLunch;
                int countDinner;
                int count;
                //各順位の食品コード,回数,食品名
                string rank1Code = string.Empty;
                int rank1Count = 0;
                string rank1Food = string.Empty;
                string rank2Code = string.Empty;
                int rank2Count = 0;
                string rank2Food = string.Empty;
                string rank3Code = string.Empty;
                int rank3Count = 0;
                string rank3Food = string.Empty;
                
                //項目ごとの回数を算出する
                for (int i = 1; i < maxNo; i++)
                {
                    T_SHOKUJI objSQL = new T_SHOKUJI();
                    try
                    {
                        countBreakfast = objSQL.CountBreakfast(i);
                        countLunch = objSQL.CountLunch(i);
                        countDinner = objSQL.CountDinner(i);
                        count = countBreakfast + countLunch + countDinner;
                    }
                    catch(SqlException sqlex)
                    {
                        MessageBox.Show(Const.DATABASE_ERROR);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Const.ERROR);
                        return;
                    }

                    
                    //1位が未入力ならば代入
                    if (rank1Code == null || rank1Code =="")
                    {
                        rank1Count = count;
                        rank1Code = i.ToString();
                    }
                    //現在の項目が1位より回数が多いとき
                    if (count > rank1Count)
                    {
                        //2位が入力されている場合は2位の項目とコードをを3位へ
                        if (rank2Code != null )
                        {
                            rank3Count = rank2Count;
                            rank3Code = rank2Code;
                        }
                        //1位の項目とコードを2位へ、現在の項目とコードを1位へ
                        rank2Count = rank1Count;
                        rank2Code = rank1Code;
                        rank1Count = count;
                        rank1Code = i.ToString();
                        
                    }
                        //現在の項目が1位と2位の間の場合
                    else if (count >rank2Count)
                    {
                        //2位が入力されている場合は2位の項目とコードを3位へ
                        if (rank2Code != null)
                        {
                            rank3Count = rank2Count;
                            rank3Code = rank2Code;
                        }
                        //現在の項目とコードを2位へ
                        rank2Count = count;
                        rank2Code = i.ToString();

                    }
                       //'現在の項目が2位と3位の間の場合
                    else if (count > rank3Count)
                    {
                        rank3Count = count;
                        rank3Code = i.ToString();
                    }
                }
                try
                {
                    rank1Food = objFood.GetFoodName(rank1Code);
                    rank2Food = objFood.GetFoodName(rank2Code);
                    rank3Food = objFood.GetFoodName(rank3Code);
                }
                catch(SqlException sqlex)
                {
                    MessageBox.Show(Const.DATABASE_ERROR);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Const.ERROR);
                    return;
                }
                MessageBox.Show(rank1Food + "：" + rank1Count + "回" + Environment.NewLine +
                                            rank2Food + "：" + rank2Count + "回" + Environment.NewLine +
                                            rank3Food + "：" + rank3Count + "回");

            }
                #endregion

            #region 1日のカロリー量の多い順が選択されたとき

                if (rdoCal.Checked)
                {
                    T_SHOKUJI objSQL = new T_SHOKUJI();
                    try
                    {
                        dgv_Shokuji.DataSource = objSQL.GetTablebyCal();
                    }
                    catch(SqlException sqlex)
                    {
                        MessageBox.Show(Const.DATABASE_ERROR);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Const.ERROR);
                        return;
                    }
                }
            #endregion
        }

        #region 全て表示ボタン

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            T_SHOKUJI objShokuji = new T_SHOKUJI();
            try
            {
                dgv_Shokuji.DataSource = objShokuji.GetTablebyDate();
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Const.ERROR);
                return;
            }
            
        }
        #endregion

        #region マスタ編集ボタン

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Master objMaster = new Master();
            objMaster.StartPosition = FormStartPosition.CenterScreen;
            objMaster.Show();
            this.Close();
        }
        #endregion

        #region データグリッドビューをダブルクリックしたとき

        private void dgv_Shokuji_DoubleClick(object sender, EventArgs e)
        {
            //ダブルクリックした行の取得
            int intRow = dgv_Shokuji.CurrentRow.Index;
            DataRowView objRowView = (DataRowView)dgv_Shokuji.Rows[intRow].DataBoundItem;

            Detail objDetail = new Detail();
            objDetail.Tag = objRowView;
            objDetail.StartPosition = FormStartPosition.CenterScreen;
            objDetail.Show();
            this.Close();
        }
        #endregion
        

    }
}
