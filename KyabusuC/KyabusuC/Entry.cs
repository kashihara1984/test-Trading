using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyabusuC.Common;
using KyabusuC.DataAceess;

namespace KyabusuC
{
    public partial class Entry : Form
    {
        //チーム名の格納
        public string E_Teamname;

        private int MAX_NUMBER = 100;
        private int MAX_Height = 250;
        private int MAX_Weight = 150;

        public Entry()
        {
            InitializeComponent();
        }
        //画面遷移
        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        

        private void Entry_Load(object sender, EventArgs e)
        {
            
            //題名
            Title.Text = E_Teamname;
            //背番号 1～100
            int[] number = new int[101];
            for (int i = 0; i < MAX_NUMBER + 1; i++)
            {
                number[i] = i;
            }
            txtNumber.DataSource = number;
            txtNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            
            //身長と体重の共通変数
            int count = 0;
            //身長
            count = 150;
            int[] height = new int[101];
            for (int i = 0; i < MAX_Height - 149; i++)
            {
                
                height[i] = count;
                count++;
            }
            txtHeight.DataSource = height;
            txtHeight.DropDownStyle = ComboBoxStyle.DropDownList;
            //体重
            count = 50;
            int[] weight = new int[101];
            for (int i = 0; i < MAX_Weight - 49; i++)
            {
                
                weight[i] = count;
                count++;
            }
            txtWeight.DataSource = weight;
            txtWeight.DropDownStyle = ComboBoxStyle.DropDownList;
            //先発又は控え
            string[] StartandSub = { "先発", "控え" };
            txtStart.DataSource = StartandSub;
            txtStart.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //トランザクションのためのフィールド
        private ThreeTeamAllPlayer EntryPlayer = new ThreeTeamAllPlayer();

        private void Uptake_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            //背番号の重複チェック
            //チーム選手の背番号の表示
            ThreeTeamAllPlayer N_AllPlayer = new ThreeTeamAllPlayer();
            N_AllPlayer.ClassTeamName = E_Teamname;
            dt = N_AllPlayer.NBAAllNumber();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtNumber.Text == dt.Rows[i][0].ToString())
                {
                    MessageBox.Show("背番号が重複しています", "警告", MessageBoxButtons.OK);
                    return;
                }
            }
            //名前とコメント　文字が入力されているか
            if (this.txtName.Text == null || this.txtName.Text == "")
            {
                MessageBox.Show("名前が未入力です", "未入力チェック", MessageBoxButtons.OK);
                this.txtName.Focus();
                return;
            }
            if (this.txtComment.Text == null || this.txtComment.Text == "")
            {
                MessageBox.Show("コメントが未入力です", "未入力チェック", MessageBoxButtons.OK);
                this.txtComment.Focus();
                return;
            }
            //名前とコメント　全角のみ入力可能
            if (Word.LenC(txtName.Text))
            {
                MessageBox.Show("半角文字が含まれています", "警告", MessageBoxButtons.OK);
                return;
            }
            if (Word.LenC(txtComment.Text))
            {
                MessageBox.Show("半角文字が含まれています", "警告", MessageBoxButtons.OK);
                return;
            }
            //先発又は控えのBIT変換
            string BIT = "";
            if (txtStart.Text == "先発")
            {
                BIT = "1";
            }
            else
            {
                BIT = "0";
            }
            //追加登録準備
           
            EntryPlayer.ClassTeamName = E_Teamname;
            EntryPlayer._number = txtNumber.Text;
            EntryPlayer._name = txtName.Text;
            EntryPlayer._height = txtHeight.Text;
            EntryPlayer._weight = txtWeight.Text;
            EntryPlayer._start = BIT;
            EntryPlayer._position = txtComment.Text;
            EntryPlayer.NBAAllEntry();
            MessageBox.Show("登録準備", "登録", MessageBoxButtons.OK);
        }

        private void EntrySet_Click(object sender, EventArgs e)
        {
            try
            {
                EntryPlayer.Decision();
                MessageBox.Show("登録しました", "登録", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                EntryPlayer.Cancel();
                MessageBox.Show("登録中止しました", "登録", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }                                                      
        }
    }
}
