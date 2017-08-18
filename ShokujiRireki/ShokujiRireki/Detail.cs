using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShokujiRireki.Common;
using ShokujiRireki.DataAccess;

namespace ShokujiRireki
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }
        //yyyyMMdd
        private const int ROWVIEW_DATE = 0;
        //yyyy年MM月dd日
        private const int ROWVIEW_DATE2 = 1;
        private const int ROWVIEW_BREAKFAST = 2;
        private const int ROWVIEW_LUNCH = 3;
        private const int ROWVIEW_DINNER = 4;
        #region フォームロード

        private void Detail_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            DataRowView objRowView;
            objRowView = (DataRowView)this.Tag;
            lblDate.Text = objRowView[ROWVIEW_DATE2].ToString();

            try
            {
                //コンボボックスの設定
            M_Food objFood = new M_Food();
            objFood.GetFoodcmb(cmbBreakfast);
            cmbBreakfast.Text = objRowView[ROWVIEW_BREAKFAST].ToString();
            objFood.GetFoodcmb(cmbLunch);
            cmbLunch.Text = objRowView[ROWVIEW_LUNCH].ToString();
            objFood.GetFoodcmb(cmbDinner);
            cmbDinner.Text = objRowView[ROWVIEW_DINNER].ToString();
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

        #region 戻るボタン

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Const.RETURN,
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

        #region 更新ボタン
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Const.CONFIRM_REGISTRY,
                                             Const.CONFIRM,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            DataRowView objRowView;
            objRowView = (DataRowView)this.Tag;
            T_SHOKUJI objShokuji = new T_SHOKUJI();
            try
            {
                objShokuji.Update(objRowView[ROWVIEW_DATE].ToString(), cmbBreakfast, cmbLunch, cmbDinner);
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
    }
}
