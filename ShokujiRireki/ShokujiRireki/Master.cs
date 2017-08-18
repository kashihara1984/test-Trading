using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShokujiRireki.DataAccess;
using ShokujiRireki.Common;
using System.Data.SqlClient;

namespace ShokujiRireki
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }


        DataTable dtFood;
        private const int COL_INDEX_DATE = 0;
        private const int COL_INDEX_CAL = 2;
        private const int COL_INDEX_DELBTN = 3;
        private const int ROW_INDEX_HEADER = -1;
        private const string ROW_CHANGED = "Flg = 1";
        private const int NAME_MAX_LENGTH = 20;
        private const int CAL_MAX_LENGTH = 10;
        #region フォームロード

        private void Master_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            //データグリッドビューのプロパティ
            dgv_Food.ReadOnly = false;
            dgv_Food.RowHeadersVisible = false;
            dgv_Food.AllowUserToAddRows = false;
            dgv_Food.AllowUserToDeleteRows = false;
            dgv_Food.AllowUserToResizeColumns = false;
            dgv_Food.AllowUserToResizeRows = false;
            dgv_Food.MultiSelect = false;
            dgv_Food.AutoGenerateColumns = false;
            

            //DataGridView上の削除ボタンを押下したときの処理用  非表示
            DataGridViewTextBoxColumn objNo = new DataGridViewTextBoxColumn();
            objNo.DataPropertyName = Const.COL_NO;

            objNo.Visible = false;
            dgv_Food.Columns.Add(objNo);
            //食品名
            DataGridViewTextBoxColumn objFoodName = new DataGridViewTextBoxColumn();
            objFoodName.ReadOnly = true;
            objFoodName.HeaderText = "食品名";
            objFoodName.SortMode = DataGridViewColumnSortMode.NotSortable;
            objFoodName.DataPropertyName = Const.COL_FOODNAME;
            dgv_Food.Columns.Add(objFoodName);
            //カロリー量
            DataGridViewTextBoxColumn objCal = new DataGridViewTextBoxColumn();
            objCal.ReadOnly = false;
            objCal.HeaderText = "カロリー数";
            objCal.SortMode = DataGridViewColumnSortMode.NotSortable;
            objCal.DataPropertyName = Const.COL_CAL;
            dgv_Food.Columns.Add(objCal);
            //削除カラムを作成し、全ての行に削除ボタンを作成する
            DataGridViewButtonColumn objDel = new DataGridViewButtonColumn();
            objDel.Name = "削除";
            objDel.UseColumnTextForButtonValue = true;
            objDel.Text = "削除ボタン";
            dgv_Food.Columns.Add(objDel);


            M_Food objFood = new M_Food();
            try
            {
                dtFood = objFood.GetMaster();
                dgv_Food.DataSource = dtFood;
                //非表示のフラグ列の追加
                DataColumn objFlg = dtFood.Columns.Add("Flg");
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Const.ERROR);
            }
            
        }
        #endregion

        #region 追加ボタン

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //未入力チェック
            if (txtName.Text == null || txtName.Text == "")
            {
                MessageBox.Show(Const.CHECK_INPUT);
                txtName.Select();
                txtName.SelectAll();
                return;
            }
            if (txtCal.Text == null || txtCal.Text == "")
            {
                MessageBox.Show(Const.CHECK_INPUT);
                txtCal.Select();
                txtCal.SelectAll();
                return;
            }
            //全角チェック
            if (txtCal.Text.Length != System.Text.Encoding.GetEncoding(932).GetByteCount(txtCal.Text))
            {
                MessageBox.Show(Const.CHECK_ZENKAKU);
                txtCal.Select();
                txtCal.SelectAll();
                return;
            }

            //文字数チェック
            if (txtName.Text.Length > NAME_MAX_LENGTH)
            {
                MessageBox.Show(Const.CHECK_LETTER_LENGTH);
                txtName.Select();
                txtName.SelectAll();
                return;
            }
            if (txtCal.Text.Length > CAL_MAX_LENGTH)
            {
                MessageBox.Show(Const.CHECK_LETTER_LENGTH);
                txtCal.Select();
                txtCal.SelectAll();
                return;
            }
            int Cal;
            if (!int.TryParse(txtCal.Text, out Cal))
            {
                MessageBox.Show(Const.NOT_NUMBER);
                txtCal.Select();
                txtCal.SelectAll();
                return;
            }
            //追加確認
            if(MessageBox.Show(Const.CONFIRM_REGISTRY,
                                            Const.CONFIRM,
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            M_Food objFood = new M_Food();
            try
            {
                objFood.InsertMaster(txtName, txtCal);
                dgv_Food.DataSource = objFood.GetMaster();
                txtName.Text = "";
                txtCal.Text = "";
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Const.ERROR);
            }
            
        }
        #endregion

        #region 更新ボタン

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //更新された行数を調べる
            DataRow[] updateRows = dtFood.Select(ROW_CHANGED);
            if (updateRows.Length == 0)
            {
                MessageBox.Show(Const.NOT_UPDATED);
                return;
            }

            //更新確認
            if(MessageBox.Show(Const.CONFIRM_REGISTRY,
                                           Const.CONFIRM,
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            
            M_Food objFood = new M_Food();
            try
            {
                objFood.UpdateMaster(updateRows);
                Main objMain = new Main();
                objMain.StartPosition = FormStartPosition.CenterScreen;
                objMain.Show();
                this.Close();
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Const.ERROR);
            }
            
        }
        #endregion


        #region データグリッドビュー上の削除ボタンが押下されたとき
        //論理削除（非表示にするがテーブルからデータの削除は行わない）
        private void dgv_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == COL_INDEX_DELBTN)
            {
                //ヘッダー行は処理しない
                if (e.RowIndex == ROW_INDEX_HEADER)
                {
                    return;
                }
                //確認メッセージ
                if(MessageBox.Show(Const.CONFIRM_DELETE,
                                               Const.CONFIRM,
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                M_Food objFood = new M_Food();
                try
                {
                    objFood.DeleteFood((int)dgv_Food.Rows[e.RowIndex].Cells[COL_INDEX_DATE].Value);
                    dgv_Food.DataSource = objFood.GetMaster();
                }
                catch(SqlException sqlex)
                {
                    MessageBox.Show(Const.DATABASE_ERROR);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Const.ERROR);
                }
                
            }
        }
        #endregion

        #region カロリー数が編集されたとき

        private void dgv_Food_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //カロリー数が変化したときのみ処理を行う
            if (e.ColumnIndex == COL_INDEX_CAL)
            {
                dtFood.Rows[e.RowIndex]["Flg"] = "1";
            }
        }
        #endregion

        #region 戻るボタン

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Const.RETURN,
                                           Const.CONFIRM,
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Main objMain = new Main();
            objMain.StartPosition = FormStartPosition.CenterScreen;
            objMain.Show();
            this.Close();
        }
        #endregion


    }
}
