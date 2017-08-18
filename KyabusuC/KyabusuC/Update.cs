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
    public partial class Update : Form
    {
        //チーム名の格納
        public string U_Teamname;

        public Update()
        {
            InitializeComponent();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new KyabusuC.Menu();
            menu.Show();
            this.Close();
        }        
        //データグリッドビューの列のオブジェクト
        private DataGridViewTextBoxColumn UniformNumber = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn pName = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn Height = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn BodyWeight = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn StartingMember = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn Position = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn TeamID = new DataGridViewTextBoxColumn();

        private void Update_Load(object sender, EventArgs e)
        {
            //題名
            Title.Text = U_Teamname;

            //データグリッドビューの設定           
            UpdateScreenDB.ReadOnly = false;
            UpdateScreenDB.RowHeadersVisible = false;
            UpdateScreenDB.AllowUserToDeleteRows = false;
            UpdateScreenDB.MultiSelect = false;
            UpdateScreenDB.AllowUserToResizeRows = false;
            UpdateScreenDB.AllowUserToDeleteRows = false;
            UpdateScreenDB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //背番号列
            UniformNumber.Name = "背番号";
            UniformNumber.ReadOnly = true;
            UniformNumber.HeaderText = "背番号";
            UniformNumber.Width = 80;
            UniformNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            UniformNumber.DataPropertyName = "UniformNumber";
            UniformNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(UniformNumber);
            //名前列
            pName.Name = "名前";
            pName.ReadOnly = true;
            pName.HeaderText = "名前";
            pName.Width = 120;
            pName.SortMode = DataGridViewColumnSortMode.NotSortable;
            pName.DataPropertyName = "Name";
            pName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(pName);
            //身長列
            Height.Name = "身長";
            Height.ReadOnly = true;
            Height.HeaderText = "身長";
            Height.Width = 80;
            Height.SortMode = DataGridViewColumnSortMode.NotSortable;
            Height.DataPropertyName = "Height";
            Height.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(Height);
            //体重列
            BodyWeight.Name = "体重";
            BodyWeight.ReadOnly = true;
            BodyWeight.HeaderText = "体重";
            BodyWeight.Width = 80;
            BodyWeight.SortMode = DataGridViewColumnSortMode.NotSortable;
            BodyWeight.DataPropertyName = "BodyWeight";
            BodyWeight.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(BodyWeight);
            //先発又は控え列
            StartingMember.Name = "先発(True)又は控え(False)";
            StartingMember.ReadOnly = true;
            StartingMember.HeaderText = "先発(True)又は控え(False)";
            StartingMember.Width = 80;
            StartingMember.SortMode = DataGridViewColumnSortMode.NotSortable;
            StartingMember.DataPropertyName = "StartingMember";
            StartingMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(StartingMember);
            //ポジション列
            Position.Name = "ポジション";
            Position.ReadOnly = true;
            Position.HeaderText = "ポジション";
            Position.Width = 120;
            Position.SortMode = DataGridViewColumnSortMode.NotSortable;
            Position.DataPropertyName = "Position";
            Position.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(Position);
            //チーム列
            TeamID.Name = "チームID";
            TeamID.Visible = false;
            TeamID.ReadOnly = true;
            TeamID.HeaderText = "チームID";
            TeamID.Width = 120;
            TeamID.SortMode = DataGridViewColumnSortMode.NotSortable;
            TeamID.DataPropertyName = "TeamID";
            TeamID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UpdateScreenDB.Columns.Add(TeamID);
            //データグリッドビューで全選手の表示
            ThreeTeamAllPlayer AllPlayer = new ThreeTeamAllPlayer();
            DataTable dt = new DataTable();
            AllPlayer.ClassTeamName = U_Teamname;
            dt = AllPlayer.NBAAllSelect();
            UpdateScreenDB.DataSource = dt;
        }
        
        //編集可
        private void Cut_Click(object sender, EventArgs e)
        {            
            UpdateScreenDB.Columns[Const.COL_Number].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_NAME].ReadOnly = false;
            UpdateScreenDB.Columns[Const.COL_Height].ReadOnly = false;
            UpdateScreenDB.Columns[Const.COL_Weight].ReadOnly = false;
            UpdateScreenDB.Columns[Const.COL_Start].ReadOnly = false;
            UpdateScreenDB.Columns[Const.COL_Position].ReadOnly = false;
            UpdateScreenDB.Columns[Const.COL_TeamName].ReadOnly = true;
        }
        //編集不可
        private void NCut_Click(object sender, EventArgs e)
        {
            UpdateScreenDB.Columns[Const.COL_Number].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_NAME].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_Height].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_Weight].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_Start].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_Position].ReadOnly = true;
            UpdateScreenDB.Columns[Const.COL_TeamName].ReadOnly = true;
        }
        //トランザクションをのためのフィールド       
        private  DataTable Updt = new DataTable();
        ThreeTeamAllPlayer UpdatePlayer = new ThreeTeamAllPlayer();
        //更新した値と更新した値と同じ行の背番号の値を取得
        //文字入力チェック
        //更新準備
        private void UpdateScreenDB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {           
            //更新した値
            string UpValue = "";
            UpValue = UpdateScreenDB.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (UpdateScreenDB.Columns[e.ColumnIndex].HeaderText == "名前")
            {
                if (UpValue == null || UpValue == "")
                {
                    MessageBox.Show("名前が未入力です", "未入力チェック", MessageBoxButtons.OK);                    
                    return;
                }
                if (Word.LenC(UpValue))
                {
                    MessageBox.Show("半角文字が含まれています", "警告", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (UpdateScreenDB.Columns[e.ColumnIndex].HeaderText == "身長")
            {
                if (Word.LenB(UpValue))
                {
                    MessageBox.Show("全角文字が含まれています", "警告", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (UpdateScreenDB.Columns[e.ColumnIndex].HeaderText == "体重")
            {
                if (Word.LenB(UpValue))
                {
                    MessageBox.Show("全角文字が含まれています", "警告", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (UpdateScreenDB.Columns[e.ColumnIndex].HeaderText == "先発(True)又は控え(False)")
            {
                if (UpValue != "True" || UpValue != "False")
                {
                    MessageBox.Show("TrueかFalseを入力して下さい", "警告", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (UpdateScreenDB.Columns[e.ColumnIndex].HeaderText == "コメント")
            {
                if (UpValue == null || UpValue == "")
                {
                    MessageBox.Show("コメントが未入力です", "未入力チェック", MessageBoxButtons.OK);
                    return;
                }
                if (Word.LenC(UpValue))
                {
                    MessageBox.Show("半角文字が含まれています", "警告", MessageBoxButtons.OK);
                    return;
                }

            }
            //更新した値の行の全ての列の値を取得
            string Number = "";
            Number = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_Number].Value.ToString();
            string pName = "";
            pName = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_NAME].Value.ToString();
            string Height = "";
            Height = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_Height].Value.ToString();
            string Weight = "";
            Weight = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_Weight].Value.ToString();
            string Start = "";
            Start = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_Start].Value.ToString();
            string Position = "";
            Position = UpdateScreenDB.Rows[e.RowIndex].Cells[Const.COL_Position].Value.ToString();
            //先発・控え変換
            if (Start == "True")
            {
                Start = "1";
            }
            else
            {
                Start = "0";
            }
            //更新準備
            UpdatePlayer.ClassTeamName = U_Teamname;
            UpdatePlayer._number = Number;
            UpdatePlayer._name = pName;
            UpdatePlayer._height = Height;
            UpdatePlayer._weight = Weight;
            UpdatePlayer._start = Start;
            UpdatePlayer._position = Position;
            UpdatePlayer.NBAAllUpdate();                        
        }
        //更新準備
        private void Uptake_Click(object sender, EventArgs e)
        {

        }
        //更新確定
        private void SetUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePlayer.Decision();
                MessageBox.Show("登録しました", "登録", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }
                 
        }
        //更新キャンセル
        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePlayer.Cancel();
                MessageBox.Show("登録中止しました", "登録", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                return;
            }
            
        }
    }
}

