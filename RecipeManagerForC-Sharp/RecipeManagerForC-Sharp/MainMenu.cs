using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeManagerForC_Sharp
{
    public partial class MainMenu : Form
    {

        int eatOut = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dgvMain.RowHeadersVisible = false;
            dgvMain.ScrollBars = ScrollBars.None;
            dgvMain.ReadOnly = false;
            dgvMain.RowHeadersVisible = false;
            dgvMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.ColumnHeadersHeight = 25;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.MultiSelect = false;
            dgvMain.AllowUserToOrderColumns = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.BackgroundColor = Color.PapayaWhip;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.Ivory;
            dgvMain.GridColor = Color.DarkOrange;
            dgvMain.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvMain.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvMain.RowsDefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
            dgvMain.RowsDefaultCellStyle.ForeColor = Color.SaddleBrown;



            DataGridViewTextBoxColumn ColCtgr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColIngr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColStyle = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColDate = new DataGridViewTextBoxColumn();
            
            ColCtgr.ReadOnly = true;
            ColCtgr.HeaderText = "カテゴリ";
            ColCtgr.Width = 55;
            ColCtgr.DataPropertyName = "Category";
            ColCtgr.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColCtgr.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns.Add(ColCtgr);

        
            ColName.ReadOnly = true;
            ColName.HeaderText = "品目名";
            ColName.Width = 210;
            ColName.DataPropertyName = "ItemName";
            ColName.DefaultCellStyle.Font = new Font(dgvMain.Font, FontStyle.Bold);
            ColName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns.Add(ColName);

         
            ColIngr.ReadOnly = true;
            ColIngr.HeaderText = "主材料";
            ColIngr.Width = 60;
            ColIngr.DataPropertyName = "MainIngredient";
            ColIngr.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColIngr.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns.Add(ColIngr);

            ColStyle.ReadOnly = true;
            ColStyle.HeaderText = "スタイル";
            ColStyle.Width = 70;
            ColStyle.DataPropertyName = "Style";
            ColStyle.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColStyle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns.Add(ColStyle);

            ColDate.ReadOnly = true;
            ColDate.HeaderText = "更新日";
            ColDate.Width = 90;
            ColDate.DataPropertyName = "LastUsedDate";
            ColDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns.Add(ColDate);

            EatoutLabel.Focus();
            EatoutLabel.Text = "";

        }   

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            try
            {
                dgvMain.DataSource = new T_RecipeDA().MainShown();
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

            dgvMain.CurrentCell = null;
            DataGridViewCellStyle RowColor = new DataGridViewCellStyle();
            RowColor.BackColor = Color.MistyRose;

            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                if (dgvMain.Rows[i].Cells[NameConst.COL_CATEGORY].Value.ToString() == "外食")
                {
                    dgvMain.Rows[i].DefaultCellStyle = RowColor;
                    eatOut += 1;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btnEatout_Click(object sender, EventArgs e)
        {
            if (EatoutLabel.Text == "")
            {
                switch (eatOut)
                {
                    case 0:
                        EatoutLabel.Text = "現在の外食率は" + eatOut + "0%です! 素晴らしいです！";
                        break;
                    case 10:
                        EatoutLabel.Text = "現在の外食率は" + eatOut + "0%です。頑張りましょう。";
                        break;
                    default:
                        EatoutLabel.Text = "現在の外食率は" + eatOut + "0%です。";
                        break;
                }
            }
            else
            {
                EatoutLabel.Text = "";
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            dgvMain.CurrentCell = null;
        }

        private void btnToList_Click(object sender, EventArgs e)
        {
            this.Close();
            RecipeList RList = new RecipeList();
            RList.Show();
        }

        private void btnToMaster_Click(object sender, EventArgs e)
        {
            this.Close();
            RecipeEdit REdit = new RecipeEdit();
            REdit.Show();
        }
    }
}
