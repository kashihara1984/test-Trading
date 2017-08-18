using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManagerForC_Sharp
{
    public partial class LogIn : Form
    {
        DataTable LoginList = new DataTable();
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtUserID.Focus();
        }
        private void LogIn_Shown(object sender, EventArgs e)
        {
            try
            {
                LoginList = new T_RecipeDA().GetAccount();
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string userId = txtUserID.Text;
            bool contains = LoginList.AsEnumerable().Any(row => userId == row.Field<string>("UserID"));
            if (!contains)
            {
                MessageBox.Show("該当ユーザはいません。");
                txtUserID.BackColor = Color.MistyRose;
                txtUserID.Focus();
                return;
            }

            DataRow[] rowArray = LoginList.Select("UserID = '" + userId + "'");
            string passWord = rowArray[NameConst.THIS_ROW].ItemArray[NameConst.COL_PASSWORD].ToString();
            string authority = rowArray[NameConst.THIS_ROW].ItemArray[NameConst.COL_AUTHORITY].ToString();
            if (txtPassword.Text != passWord)
            {
                MessageBox.Show("パスワードが間違っています。");
                txtPassword.BackColor = Color.MistyRose;
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text == passWord && authority == "1")
            {
                //login as admin
                this.Hide();
                MainMenu MainM = new MainMenu();
                MainM.Show();
            }
            if (txtPassword.Text == passWord && authority == "0")
            {
                //login as user
                this.Hide();
                MainMenu MainM = new MainMenu();
                MainM.Show();
                MainM.btnToMaster.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtUserID);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtPassword);
        }


    }
}
