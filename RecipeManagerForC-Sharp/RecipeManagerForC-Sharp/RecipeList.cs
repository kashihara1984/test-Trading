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

namespace RecipeManagerForC_Sharp
{
    public partial class RecipeList : Form
    {
        public RecipeList()
        {
            InitializeComponent();
        }


        DataTable dtList = new DataTable();

        private void RecipeList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dgvList.ScrollBars = ScrollBars.Vertical;
            dgvList.ReadOnly = false;
            dgvList.RowHeadersVisible = false;
            dgvList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvList.ColumnHeadersHeight = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.MultiSelect = false;
            dgvList.AllowUserToOrderColumns = false;
            dgvList.AllowUserToResizeColumns = false;
            dgvList.AllowUserToResizeRows = false;
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;

            dgvList.BorderStyle = BorderStyle.None;
            dgvList.BackgroundColor = Color.PapayaWhip;
            dgvList.EnableHeadersVisualStyles = false;
            dgvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Ivory;
            dgvList.GridColor = Color.DarkOrange;
            dgvList.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvList.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvList.RowsDefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
            dgvList.RowsDefaultCellStyle.ForeColor = Color.SaddleBrown;


            DataGridViewTextBoxColumn ColNo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColCtgr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColIngr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColStyle = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColRate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColTime = new DataGridViewTextBoxColumn();


            ColNo.DataPropertyName = "ItemNo";
            ColNo.Visible = false;
            dgvList.Columns.Add(ColNo);

            ColCtgr.ReadOnly = true;
            ColCtgr.HeaderText = "カテゴリ";
            ColCtgr.Width = 65;
            ColCtgr.DataPropertyName = "Category";
            ColCtgr.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColCtgr.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns.Add(ColCtgr);

            ColName.ReadOnly = true;
            ColName.HeaderText = "品目名";
            ColName.Width = 150;
            ColName.DataPropertyName = "ItemName";
            ColName.DefaultCellStyle.Font = new Font(dgvList.Font, FontStyle.Bold);
            ColName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns.Add(ColName);

            ColIngr.ReadOnly = true;
            ColIngr.HeaderText = "主材料";
            ColIngr.Width = 50;
            ColIngr.DataPropertyName = "MainIngredient";
            ColIngr.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColIngr.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns.Add(ColIngr);

            ColStyle.ReadOnly = true;
            ColStyle.HeaderText = "スタイル";
            ColStyle.Width = 65;
            ColStyle.DataPropertyName = "Style";
            ColStyle.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColStyle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns.Add(ColStyle);

            ColTime.ReadOnly = true;
            ColTime.HeaderText = "所要時間";
            ColTime.Width = 65;
            ColTime.DataPropertyName = "CookTime";
            ColTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColTime.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns.Add(ColTime);

            ColRate.ReadOnly = true;
            ColRate.HeaderText = "レート";
            ColRate.Width = 70;
            ColRate.DataPropertyName = "Stars";
            ColRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColRate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns.Add(ColRate);

            dgvList.CurrentCell = null;
            this.ActiveControl = this.label1;
        }

        private void RecipeList_Shown(object sender, EventArgs e)
        {
            try
            {
                dtList = new T_RecipeDA().ListShown(null);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

            DataView ViewStyle = new DataView(dtList);
            DataTable distinctStyle = new DataTable();
            distinctStyle = ViewStyle.ToTable(true, "Style");


            cmbStyle.DataSource = distinctStyle;
            cmbStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStyle.ValueMember = "Style";
            cmbStyle.DisplayMember = "Style";
            cmbStyle.SelectedValue = -1;

            DataView ViewIngr = new DataView(dtList);
            DataTable distinctIngre = new DataTable();
            distinctIngre = ViewStyle.ToTable(true, "MainIngredient");
            cmbIngre.DataSource = distinctIngre;
            cmbIngre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngre.ValueMember = "MainIngredient";
            cmbIngre.DisplayMember = "MainIngredient";
            cmbIngre.SelectedValue = -1;


            DataTable dtTime = new DataTable();
            dtTime.Columns.Add("時間");
            dtTime.Columns.Add("Time");
            dtTime.Rows.Add("１５分以内", " 00:15:00 ");
            dtTime.Rows.Add("３０分以内", " 00:30:00 ");
            dtTime.Rows.Add("４５分以内", " 00:45:00 ");
            dtTime.Rows.Add("１時間以内", " 01:00:00 ");
            dtTime.Rows.Add("一時間以上", " 01:00:00 ");


            cmbTime.DataSource = dtTime;
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.ValueMember = "Time";
            cmbTime.DisplayMember = "時間";
            cmbTime.SelectedValue = -1;

            DataView ViewCateg = new DataView(dtList);
            DataTable distinctCateg = new DataTable();
            distinctCateg = ViewStyle.ToTable(true, "Category");
            cmbCateg.DataSource = distinctCateg;
            cmbCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCateg.ValueMember = "Category";
            cmbCateg.DisplayMember = "Category";
            cmbCateg.SelectedValue = -1;

            DataTable dtRate = new DataTable();
            dtRate.Columns.Add("レート");
            dtRate.Columns.Add("Rate");
            dtRate.Rows.Add("☆以上", " 1 ");
            dtRate.Rows.Add("☆☆以上", " 2 ");
            dtRate.Rows.Add("☆☆☆以上", " 3 ");
            dtRate.Rows.Add("☆☆☆☆以上", " 4 ");
            dtRate.Rows.Add("☆☆☆☆☆", "  5 ");

            cmbRate.DataSource = dtRate;
            cmbRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRate.ValueMember = "Rate";
            cmbRate.DisplayMember = "レート";
            cmbRate.SelectedValue = -1;

            txtPreview.ReadOnly = true;
            txtPreview.Text = "";

            txtKeyword.Text = "";
        }

        private void RecipeList_Click(object sender, EventArgs e)
        {
            dgvList.CurrentCell = null;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string RecipeText = string.Empty;
            DataTable dtRpreview = new DataTable();
            dtRpreview.Clear();
            txtPreview.Text = string.Empty;
            int rowNum = dgvList.CurrentRow.Index;
            string ItemNo = dtList.Rows[rowNum].ItemArray[NameConst.COL_RECIPE].ToString().Trim();

            try
            {
                dtRpreview = new T_RecipeDA().ListPreview(ItemNo);
                RecipeText = dtRpreview.Rows[NameConst.ROW_RECIPETEXT].ItemArray[NameConst.COL_RECIPETEXT].ToString().Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("～に失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

            if (RecipeText == null || RecipeText == "")
            {
                txtPreview.Text = "レシピなし";
            }
            else
            {
                txtPreview.Text = RecipeText;
            }

            if (RecipeText.Length > 40)
            {
                txtPreview.Text = RecipeText.Substring(0, 40) + "...";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu MMenu = new MainMenu();
            MMenu.Show();
        }



        private SearchRecipeModel SetSearchValue() 
        {
            SearchRecipeModel model = new SearchRecipeModel();
            int Over1H = 4;
            model.cmbStyleValue = cmbStyle.SelectedValue == null ? "" : cmbStyle.SelectedValue.ToString();
            model.cmbIngreValue = cmbIngre.SelectedValue == null ? "" : cmbIngre.SelectedValue.ToString();
            model.cmbTimeValue = cmbTime.SelectedValue == null ? "" : cmbTime.SelectedValue.ToString();
            int selIndex = cmbTime.SelectedIndex; // == null ? -1 : cmbTime.SelectedIndex;
            model.isOverTime = selIndex == Over1H ? true : false;
            model.cmbCategValue = cmbCateg.SelectedValue == null ? "" : cmbCateg.SelectedValue.ToString();
            model.cmbRateValue = cmbRate.SelectedValue == null ? "" : cmbRate.SelectedValue.ToString();
            model.txtKeyWordValue = txtKeyword.Text;

            return model;
        }

        private void cmbStyle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbIngre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbTime_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                SearchRecipeModel model = SetSearchValue();
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbStyle.SelectedValue = -1;
            cmbIngre.SelectedValue = -1;
            cmbTime.SelectedValue = -1;
            cmbCateg.SelectedValue = -1;
            cmbRate.SelectedValue = -1;
            txtKeyword.Text = string.Empty;
            txtPreview.Text = string.Empty;
            SearchRecipeModel model = SetSearchValue();

            try
            {
                dtList = new T_RecipeDA().ListShown(model);
                dgvList.DataSource = dtList;
                dgvList.CurrentCell = null;

            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

        }
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNum = dgvList.CurrentRow.Index;
            T_RecipeDA.ItemNumber = dtList.Rows[rowNum].ItemArray[NameConst.COL_RECIPENO].ToString().Trim();

            Recipe Rp = new Recipe();
            Rp.Show();
            this.Close();
        }

        private void dgvList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvList_CellClick(null, null);
        }
    }
}
