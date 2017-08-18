using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyabusuC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       
        //キャバリアーズ
        private void CAVS_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Search seach = new KyabusuC.Search();
            seach.TeamName = "キャバリアーズ";
            seach.Show();           
        }
        //ウォーリアーズ
        private void GSW_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Search seach = new KyabusuC.Search();
            seach.TeamName = "ウォーリアーズ";
            seach.Show();            
        }
        //セルティックス
        private void BOS_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Search seach = new KyabusuC.Search();
            seach.TeamName = "セルティックス";
            seach.Show();            
        }
        //閉じる
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
