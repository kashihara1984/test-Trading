using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyabusuC.DataAceess;

namespace KyabusuC
{
    public partial class Transfers : Form
    {
        //チーム名の格納
        public string T_TeamName;

        public Transfers()
        {
            InitializeComponent();
        }       
        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new KyabusuC.Menu();
            menu.Show();
            this.Close();
        }

        private T_CAVS C_PlayerTransfer = new T_CAVS();
        private T_BOS B_PlayerTransfer = new T_BOS();
        private T_GSW G_PlayerTransfer = new T_GSW();
        

        private void Transfers_Load(object sender, EventArgs e)
        {
            Title.Text = T_TeamName;
            //選手名の配列の格納変数


            //コンボボックスに在籍選手の名前を入れる
            ThreeTeamAllPlayer TransPlayer = new ThreeTeamAllPlayer();
            DataTable dt = new DataTable();
            TransPlayer.ClassTeamName = T_TeamName;
            dt = TransPlayer.NBAAllName();
            string[] PlayerName = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PlayerName[i] = dt.Rows[i][0].ToString();
                }
                TransferPlayer.DataSource = PlayerName;
                TransferPlayer.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private ThreeTeamAllPlayer PlayerTransfer = new ThreeTeamAllPlayer();
        //削除するかどうかの留保
        private void Uptake_Click(object sender, EventArgs e)
        {
            PlayerTransfer.ClassTeamName = T_TeamName;
            PlayerTransfer._name = TransferPlayer.Text;
            PlayerTransfer.TransMan();
            MessageBox.Show("移籍準備", "移籍", MessageBoxButtons.OK);
        }
        //削除の実行
        private void TransferSet_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerTransfer.Decision();
                MessageBox.Show("移籍完了", "移籍", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }
           
        }
        //削除の取り消し
        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerTransfer.Cancel();
                MessageBox.Show("移籍取消", "移籍", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }
           
        }
    }
}
