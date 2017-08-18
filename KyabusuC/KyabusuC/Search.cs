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
    public partial class Search : Form
    {
        //チーム名の格納
        public string TeamName;

        public Search()
        {
            InitializeComponent();
        }
        //メニュー画面に戻る
        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new KyabusuC.Menu();
            menu.Show();

        }
        //フォームロード時に題名とデータグリッドビューの設定
        private void Search_Load(object sender, EventArgs e)
        {
            //題名
            Title.Text = TeamName;

            //データグリッドビューの設定           
            Player.ReadOnly = false;
            Player.RowHeadersVisible = false;
            Player.AllowUserToDeleteRows = false;
            Player.MultiSelect = false;
            Player.AllowUserToResizeRows = false;
            Player.AllowUserToDeleteRows = false;
            Player.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //背番号列
            DataGridViewTextBoxColumn UniformNumber = new DataGridViewTextBoxColumn();
            UniformNumber.ReadOnly = true;
            UniformNumber.HeaderText = "背番号";
            UniformNumber.Width = 80;
            UniformNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            UniformNumber.DataPropertyName = "UniformNumber";
            UniformNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(UniformNumber);
            //名前列
            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.ReadOnly = true;
            Name.HeaderText = "名前";
            Name.Width = 120;
            Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            Name.DataPropertyName = "Name";
            Name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(Name);
            //身長列
            DataGridViewTextBoxColumn Height = new DataGridViewTextBoxColumn();
            Height.ReadOnly = true;
            Height.HeaderText = "身長";
            Height.Width = 80;
            Height.SortMode = DataGridViewColumnSortMode.NotSortable;
            Height.DataPropertyName = "Height";
            Height.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(Height);
            //体重列
            DataGridViewTextBoxColumn BodyWeight = new DataGridViewTextBoxColumn();
            BodyWeight.ReadOnly = true;
            BodyWeight.HeaderText = "体重";
            BodyWeight.Width = 80;
            BodyWeight.SortMode = DataGridViewColumnSortMode.NotSortable;
            BodyWeight.DataPropertyName = "BodyWeight";
            BodyWeight.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(BodyWeight);
            //先発又は控え列
            DataGridViewTextBoxColumn StartingMember = new DataGridViewTextBoxColumn();
            StartingMember.ReadOnly = true;
            StartingMember.HeaderText = "先発(True)又は控え(False)";
            StartingMember.Width = 80;
            StartingMember.SortMode = DataGridViewColumnSortMode.NotSortable;
            StartingMember.DataPropertyName = "StartingMember";
            StartingMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(StartingMember);
            //コメント列
            DataGridViewTextBoxColumn Position = new DataGridViewTextBoxColumn();
            Position.ReadOnly = true;
            Position.HeaderText = "ポジション";
            Position.Width = 120;
            Position.SortMode = DataGridViewColumnSortMode.NotSortable;
            Position.DataPropertyName = "Position";
            Position.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(Position);
            //チーム列
            DataGridViewTextBoxColumn TeamID = new DataGridViewTextBoxColumn();
            TeamID.Visible = false;
            TeamID.ReadOnly = true;
            TeamID.HeaderText = "チームID";
            TeamID.Width = 120;
            TeamID.SortMode = DataGridViewColumnSortMode.NotSortable;
            TeamID.DataPropertyName = "TeamID";
            TeamID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Player.Columns.Add(TeamID);
        }

        private DataTable dt = new DataTable();

        private void Search_Shown(object sender, EventArgs e)
        {
            //データグリッドビューで全選手の表示
            ThreeTeamAllPlayer AllPlayer = new ThreeTeamAllPlayer();
            AllPlayer.ClassTeamName = TeamName;
            dt = AllPlayer.NBAAllSelect();
            Player.DataSource = dt;
        }               
        private void Starting_Click(object sender, EventArgs e)
        {
            //データグリッドビューで先発の全選手の表示
            ThreeTeamAllPlayer S_AllPlayer = new ThreeTeamAllPlayer();
            S_AllPlayer.ClassTeamName = TeamName;
            dt = S_AllPlayer.NBAAllStart();
            Player.DataSource = dt;
        }

        private void Height_Click(object sender, EventArgs e)
        {
            //データグリッドビューで２M以上の全選手の表示
            ThreeTeamAllPlayer H_AllPlayer = new ThreeTeamAllPlayer();
            H_AllPlayer.ClassTeamName = TeamName;
            dt = H_AllPlayer.NBAAllHeight();
            Player.DataSource = dt;
        }

        private void Position_Click(object sender, EventArgs e)
        {
            ThreeTeamAllPlayer P_AllPlayer = new ThreeTeamAllPlayer();
            P_AllPlayer.ClassTeamName = TeamName;
            if (Guard.Checked == true)
            {
                P_AllPlayer._position = "ガード";
            }
            else if (Foward.Checked == true)
            {
                P_AllPlayer._position = "フォワード";
            }
            else if (Center.Checked == true)
            {
                P_AllPlayer._position = "センター";
            }
            dt = P_AllPlayer.NBAAllPosition();
            Player.DataSource = dt;
           
        }
        //登録画面に画面遷移
        private void Entrybtn_Click(object sender, EventArgs e)
        {
            Entry entry = new KyabusuC.Entry();
            entry.E_Teamname = TeamName;
            entry.Show();
            this.Hide();
        }
        //移籍画面へ画面遷移
        private void Transfer_Click(object sender, EventArgs e)
        {
            Transfers transfers = new Transfers();
            transfers.T_TeamName = TeamName;
            transfers.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Update update = new KyabusuC.Update();
            update.U_Teamname = TeamName;
            update.Show();
            this.Hide();
        }
    }
}
