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
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }
        #region フォームロード

        private void Registry_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            M_Food objFood = new M_Food();
            try
            {
                objFood.GetFoodcmb(cmbBreakfast);
                objFood.GetFoodcmb(cmbLunch);
                objFood.GetFoodcmb(cmbDinner);
            }
            catch (SqlException sqlex)
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
            else
            {
                Main objMain = new Main();
                objMain.StartPosition = FormStartPosition.CenterScreen;
                objMain.Show();
                this.Close();
            }
        }
        #endregion

        #region 追加ボタン

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //入力チェック(未来の日付では登録できない)
            DateTime timeNow = System.DateTime.Now;
            //int.Perse(aaa)----->文字列aaaをint型に変換
            if (int.Parse(dtp_Hiduke.Value.ToString("yyyyMMdd")) > int.Parse(timeNow.ToString("yyyyMMdd")))
            {
                MessageBox.Show(Const.CHECK_DATE);
                return;
            }

            //未選択チェック
            if (cmbBreakfast.SelectedValue == null || cmbLunch.SelectedValue == null || cmbDinner.SelectedValue == null) 
            {
                MessageBox.Show(Const.CHECK_CMB);
                return;
            }

            //登録確認メッセージ
            if (MessageBox.Show(Const.CONFIRM_REGISTRY,
                                            Const.CONFIRM,
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }


            //重複チェック(日付チェック)
            T_SHOKUJI objShokuji = new T_SHOKUJI();
            try
            {
                int count = objShokuji.CheckKeyDate(dtp_Hiduke.Value.ToString("yyyyMMdd"));
                if (count == 1)
                {
                    MessageBox.Show(Const.CHECK_HIDUKE, "重複チェック");
                    return;
                }
                objShokuji.Registry(dtp_Hiduke.Value.ToString("yyyyMMdd"), cmbBreakfast, cmbLunch, cmbDinner);

            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Const.ERROR);
            }
            finally
            {
                Main objMain = new Main();
                objMain.StartPosition = FormStartPosition.CenterScreen;
                objMain.Show();
                this.Close();
            }
        }
        #endregion


    }
}
