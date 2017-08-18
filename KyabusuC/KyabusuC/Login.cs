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
using KyabusuC.Common;
using KyabusuC.DataAceess;

namespace KyabusuC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            //各テキストボックスの未入力チェック
            if(this.userID.Text == null || this.userID.Text  == "")
            {
                MessageBox.Show("ユーザIDが未入力です", "未入力チェック", MessageBoxButtons.OK);
                this.userID.Focus();
                return;
             }
            if (this.pass.Text == null || this.pass.Text == "")
            {
                MessageBox.Show("パスワードが未入力です", "未入力チェック", MessageBoxButtons.OK);
                this.pass.Focus();
                return;
            }
            
            //ユーザーIDの半角チェック
            if(Word.LenB(userID.Text))
            {
                MessageBox.Show("全角文字が含まれています", "半角チェック", MessageBoxButtons.OK);
                this.userID.Focus();
                return;
            }
            //ユーザID/文字数チェック～5文字固定
            if(userID.Text.Length != 5)
            {
                MessageBox.Show("文字数が不正です", "文字数チェック", MessageBoxButtons.OK);
                this.userID.Focus();
                return;
            }
            //パスワード/半角チェック
            if (Word.LenB(pass.Text))
            {
                MessageBox.Show("全角文字が含まれています", "半角チェック", MessageBoxButtons.OK);
                this.pass.Focus();
                return;
            }
            //パスワード/文字数チェック～5文字固定
            if (pass.Text.Length != 5)
            {
                MessageBox.Show("文字数が不正です", "文字数チェック", MessageBoxButtons.OK);
                this.pass.Focus();
                return;
            }
            //ログインデータテーブル
            DataTable L_dt = new DataTable();
            //ID/PASS重複チェック
            T_Login t_login1 = new T_Login(1,userID.Text,pass.Text);
            L_dt = t_login1.CL_dt;
            if (L_dt.Rows.Count == 0)
            {
                MessageBox.Show("ユーザーIDかパスワードが違います", "警告", MessageBoxButtons.OK);
                return;
            }
            //ロックフラグチェック
            T_Login t_login2 = new T_Login(2, userID.Text, pass.Text);
            L_dt = t_login2.CL_dt;
            if (L_dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("ようこそ", "成功", MessageBoxButtons.OK);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }       
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
