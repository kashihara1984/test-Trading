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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static Login _LoginForm;
        public static Login LoginForm
        {
            get { return _LoginForm; }
            set { _LoginForm = value; }
        }

        private string user;
        private int unmatch;


        #region フォームロード
        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion

        #region ログインボタン
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //入力チェック
            if (txtUser.Text == null || txtUser.Text == "")
            {
                MessageBox.Show(Const.CHECK_INPUT);
                txtUser.Select();
                return;
            }
            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show(Const.CHECK_INPUT);
                return;
            }

            if (txtUser.Text.Length != System.Text.Encoding.GetEncoding(932).GetByteCount(txtUser.Text))
            {
                MessageBox.Show(Const.CHECK_ZENKAKU);
                txtUser.Select();
                txtUser.SelectAll();
                return;
            }
            if (txtPassword.Text.Length != System.Text.Encoding.GetEncoding(932).GetByteCount(txtPassword.Text))
            {
                MessageBox.Show(Const.CHECK_ZENKAKU);
                txtPassword.Select();
                txtPassword.SelectAll();
                return;
            }
            //最後に入力したユーザー名と今回入力したユーザ名が違う場合はアンマッチ回数をリセット
            if (user != txtUser.Text)
            {
                unmatch = 0;
            }
            //最後に入力したユーザー名に今回入力したユーザ名を代入
            user = txtUser.Text;

            try
            {
                M_USER objUser = new M_USER();
                //該当ユーザがいないとき
                if (objUser.GetUserCount(txtUser.Text) == 0)
                {
                    MessageBox.Show(Const.NO_USER);
                    return;
                }

                //ロックがかけられているユーザー
                if (objUser.GetNoLockedUserCount(txtUser.Text) == 0)
                {
                    MessageBox.Show(Const.LOCKED_USER);
                    this.Close();
                }

                //パスワードが一致するユーザー
                if (objUser.GetLoginUserCount(txtUser.Text, txtPassword.Text) == 1)
                {
                    //メイン画面に遷移
                    MessageBox.Show("ログイン成功", "認証");
                    Main objMain = new Main();
                    objMain.StartPosition = FormStartPosition.CenterScreen;
                    _LoginForm = this;
                    objMain.Show();
                    this.Hide();
                }
                else
                {
                    //パスワードが一致しない場合
                    MessageBox.Show(Const.UNMATCH_PASSWORD);
                    unmatch++;
                    //3回同じユーザーでパスワードを間違えたとき
                    if (unmatch > 2)
                    {
                        objUser.LockUser(txtUser.Text);
                        this.Close();
                    }
                    return;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(Const.DATABASE_ERROR);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(Const.ERROR);
                return;
            }
            


        }
        #endregion

        #region 閉じるボタン
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
