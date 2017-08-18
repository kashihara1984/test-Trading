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
    public partial class RecipeEdit : Form
    {
        public RecipeEdit()
        {
            InitializeComponent();
        }
        DataTable dtSelect = new DataTable();
        DataTable dtEdit = new DataTable();
        T_RecipeDA Rda = new T_RecipeDA();
        private void RecipeEdit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            dgvEdit.ReadOnly = true;
            dgvEdit.ScrollBars = ScrollBars.Vertical;
            dgvEdit.ReadOnly = false;
            dgvEdit.RowHeadersVisible = false;
            dgvEdit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEdit.ColumnHeadersHeight = 25;
            dgvEdit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEdit.MultiSelect = false;
            dgvEdit.AllowUserToOrderColumns = false;
            dgvEdit.AllowUserToResizeColumns = false;
            dgvEdit.AllowUserToResizeRows = false;
            dgvEdit.AllowUserToAddRows = false;
            dgvEdit.AllowUserToDeleteRows = false;
            dgvEdit.BorderStyle = BorderStyle.None;
            dgvEdit.BackgroundColor = Color.PapayaWhip;
            dgvEdit.EnableHeadersVisualStyles = false;
            dgvEdit.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvEdit.ColumnHeadersDefaultCellStyle.ForeColor = Color.Ivory;
            dgvEdit.GridColor = Color.DarkOrange;
            dgvEdit.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvEdit.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvEdit.RowsDefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
            dgvEdit.RowsDefaultCellStyle.ForeColor = Color.SaddleBrown;

            DataGridViewTextBoxColumn ColItemNo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColItemName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColDate = new DataGridViewTextBoxColumn();
            
            ColItemNo.ReadOnly = true;
            ColItemNo.HeaderText = "No.";
            ColItemNo.Width = 30;
            ColItemNo.DataPropertyName = "ItemNo";
            ColItemNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColItemNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEdit.Columns.Add(ColItemNo);

            ColItemName.ReadOnly = true;
            ColItemName.HeaderText = "品目名";
            ColItemName.Width = 145;
            ColItemName.DataPropertyName = "ItemName";
            ColItemName.DefaultCellStyle.Font = new Font(dgvEdit.Font, FontStyle.Bold);
            ColItemName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColItemName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEdit.Columns.Add(ColItemName);

            ColDate.ReadOnly = true;
            ColDate.HeaderText = "更新日時";
            ColDate.Width = 80;
            ColDate.DataPropertyName = "LastUsedDate";
            ColDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEdit.Columns.Add(ColDate);

            TextChecker.ColorChange(txtRecipe);
            TextChecker.ColorChange(txtCateg);
            TextChecker.ColorChange(txtIngre);
            TextChecker.ColorChange(txtTime);
            TextChecker.ColorChange(txtStyle);
            TextChecker.ColorChange(txtRname);
            TitlePanel.BackColor = Color.MistyRose;

        }

        private void RecipeEdit_Shown(object sender, EventArgs e)
        {
            try
            {
                dtEdit = new T_RecipeDA().EditShown();
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

            DataTable dtRate =new DataTable();
            dtRate.Columns.Add("レート");
            dtRate.Columns.Add("Rate");
            dtRate.Rows.Add("なし", "");
            dtRate.Rows.Add("☆", "1");
            dtRate.Rows.Add("☆☆", "2");
            dtRate.Rows.Add("☆☆☆", "3");
            dtRate.Rows.Add("☆☆☆☆", "4");
            dtRate.Rows.Add("☆☆☆☆☆", "5");


            cmbRate.DataSource = dtRate;
            cmbRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRate.ValueMember = "Rate";
            cmbRate.DisplayMember = "レート";
            cmbRate.SelectedValue = -1;

            DataView NumberNameView = new DataView(dtEdit);
            dgvEdit.DataSource = NumberNameView.ToTable(false, "ItemNo", "ItemName", "LastUsedDate");

            dgvEdit.CurrentCell = null;
        }

        private void dgvEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowPosition = dgvEdit.CurrentRow.Index;
            string ItemNo = dtEdit.Rows[RowPosition].ItemArray[0].ToString();
            T_RecipeDA.ItemNumber = ItemNo;

            try
            {
                dtSelect = new T_RecipeDA().EditSelect();
            }
            catch (Exception)
            {
                    MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                        "詳しくは管理者までお問い合わせください。");
                    Application.Exit();
            }

            lblRnumber.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_NUMBER].ToString();
            txtRname.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_NAME].ToString();
            txtIngre.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_INGRE].ToString();
            txtStyle.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_STYLE].ToString();

            if (string.IsNullOrEmpty(dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_RECIPE].ToString()))
            {
                txtRecipe.Text = "レシピなし";
            }
            else
            {
                txtRecipe.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_RECIPE].ToString();
            }
             
            txtRecipe.ReadOnly = false;
            txtRecipe.ScrollBars = ScrollBars.Vertical;

            txtTime.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_TIME].ToString();
            txtCateg.Text = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_CATEG].ToString();
            cmbRate.SelectedValue = dtSelect.Rows[NameConst.EROW_SELECTED].ItemArray[NameConst.ECOL_RATE];
         }

        private void btnRecipeBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu MMenu = new MainMenu();
            MMenu.Show();
        }

        private void btnSetRecipe_Click(object sender, EventArgs e)
        {

            lblRnumber.Text = "新規";
            
            txtRname.Text = "レシピ名";
            txtRname.BackColor = Color.MistyRose;
            txtRname.ForeColor = Color.Gray;
            TitlePanel.BackColor = Color.MistyRose;

            txtStyle.Text = "和/洋etc";
            txtStyle.BackColor = Color.MistyRose;
            txtStyle.ForeColor = Color.Gray;

            txtTime.Text = "00:00:00";
            txtTime.BackColor = Color.MistyRose;
            txtTime.ForeColor = Color.Gray;

            txtIngre.Text = "米/パスタ";
            txtIngre.BackColor = Color.MistyRose;
            txtIngre.ForeColor = Color.Gray;

            txtCateg.Text = "主菜/弁当etc";
            txtCateg.BackColor = Color.MistyRose;
            txtCateg.ForeColor = Color.Gray;

            txtRecipe.Text = "レシピなし";
            txtRecipe.BackColor = Color.MistyRose;
            txtRecipe.ForeColor = Color.Gray;

            cmbRate.SelectedValue = "";

            MessageBox.Show("各項目入力し、新規登録ボタンを押してください");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lblRnumber.Text != "新規")
            {
                MessageBox.Show("新規作成ボタンを押して下さい。");
                return;
            }
            if (txtRname.Text == "レシピ名")
            {
                MessageBox.Show("レシピ名は必ず入力して下さい。");
                return;
            }

            if (MessageBox.Show("「" + txtRname.Text + "」を登録します。" + Environment.NewLine + 
                "よろしいですか？", "登録", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                try
                {
                    Rda.EditInsert(SetSearchValue());
                    MessageBox.Show("登録が完了しました!");
                }
                catch (Exception)
                {
                    MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                        "詳しくは管理者までお問い合わせください。");
                    Application.Exit();
                }
            }
            else
            {
                return;
            }
            dtEdit.Columns.Clear();
            dtEdit.Clear();
            RecipeEdit_Shown(null, null);
            int lastRow = dgvEdit.RowCount - 1;
            dgvEdit.CurrentCell = dgvEdit.Rows[lastRow].Cells[NameConst.ECOL_NUMBER];
            dgvEdit_CellClick(null, null);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRname.Text) || (txtRname.Text == "レシピ名"))
            {
                MessageBox.Show("品目を選択して下さい。");
                return;
            }
            if (MessageBox.Show("「" + txtRname.Text + "」の内容を更新します。" + Environment.NewLine +
                "本当によろしいですか？", "更新", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    Rda.EditUpdate(SetSearchValue());
                    MessageBox.Show("更新しました!");
                }
                catch (Exception)
                {
                    MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                        "詳しくは管理者までお問い合わせください。");
                    Application.Exit();
                }
            }
            else
            {
                return;
            }
            dtEdit.Columns.Clear();
            dtEdit.Clear();
            RecipeEdit_Shown(null, null);
            dgvEdit.CurrentCell = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblRnumber.Text == "新規" || lblRnumber.Text == "")
            {
            MessageBox.Show("登録されていない商品は削除できません。");
                return;
            }

            if (MessageBox.Show("「" + txtRname.Text + "」を削除します。" + Environment.NewLine +
                "本当によろしいですか？", "削除", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    Rda.EditDelete(SetSearchValue());
                    MessageBox.Show("削除しました");
                }
                catch (Exception)
                {
                    MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                        "詳しくは管理者までお問い合わせください。");
                    Application.Exit();
                }

            }
            else
            {
                return;
            }
            dtEdit.Columns.Clear();
            dtEdit.Clear();
            RecipeEdit_Shown(null, null);
            int lastRow = dgvEdit.RowCount - 1;
            dgvEdit.CurrentCell = dgvEdit.Rows[lastRow].Cells[NameConst.ECOL_NUMBER];
            dgvEdit_CellClick(null, null);
        }

        private SearchRecipeModel SetSearchValue() 
        {
            SearchRecipeModel model = new SearchRecipeModel();
            model.lblRnumberValue = lblRnumber.Text == null ? "" :lblRnumber.Text;
            model.txtRnameValue = txtRname.Text == null ? "" : txtRname.Text;
            model.txtIngreValue = txtIngre.Text == null ? "" : txtIngre.Text;
            model.txtStyleValue = txtStyle.Text == null ? "" : txtStyle.Text;
            model.txtRecipeValue =txtRecipe.Text== null ? "" : txtRecipe.Text;
            model.txtTimeValue = txtTime.Text == null ? "" : txtTime.Text;
            model.txtCategValue = txtCateg.Text == null ? "" : txtCateg.Text;
            model.cmbEditRateValue = cmbRate.SelectedValue == null ? "" : cmbRate.SelectedValue.ToString();

            return model;
        }

        private void txtRname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRname.Text))
            {
                txtRname.BackColor = Color.MistyRose;
                txtRname.ForeColor = Color.Gray;
                TitlePanel.BackColor = Color.MistyRose;
            }
            else
            {
                txtRname.BackColor = Color.FloralWhite;
                txtRname.ForeColor = Color.DarkRed;
                TitlePanel.BackColor = Color.FloralWhite;
            }

            if (txtRname.Text.Length > 9)
            {
                txtRname.Font = new Font(txtRname.Font.FontFamily, 20);
            }
            else
            {
                txtRname.Font = new Font(txtRname.Font.FontFamily, 28);
            }

        }
        private void txtRname_Enter(object sender, EventArgs e)
        {
            if (txtRname.Text == "レシピ名")
            {
                txtRname.Text = "";
            }
            
        }
        private void txtRname_Leave(object sender, EventArgs e)
        {
            if (txtRname.Text == "" || txtRname.Text =="レシピ名")
            {
                txtRname.Text = "レシピ名";
                txtRname.BackColor = Color.MistyRose;
                txtRname.ForeColor = Color.Gray;
            }
        }

        private void txtStyle_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtStyle);
        }
        private void txtStyle_Enter(object sender, EventArgs e)
        {
            if (txtStyle.Text == "和/洋etc")
            {
                txtStyle.Text = "";
            }
        }

        private void txtStyle_Leave(object sender, EventArgs e)
        {
            if (txtStyle.Text == "")
            {
            txtStyle.Text = "和/洋etc";
            txtStyle.BackColor = Color.MistyRose;
            txtStyle.ForeColor = Color.Gray;
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtTime);
        }
        //private void txtTime_Enter(object sender, EventArgs e)
        //{
        //    if (txtTime.Text == "00:00:00")
        //    {
        //        txtTime.Text = "";
        //    }
        //}
        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (txtTime.Text == "")
            {
                txtTime.Text = "00:00:00";
                txtTime.BackColor = Color.MistyRose;
                txtTime.ForeColor = Color.Gray;
            }
        }

        private void txtIngre_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtIngre);
        }
        private void txtIngre_Enter(object sender, EventArgs e)
        {
            if (txtIngre.Text == "米/パスタ")
            {
                txtIngre.Text = "";
            }
        }
        private void txtIngre_Leave(object sender, EventArgs e)
        {
            if (txtIngre.Text == "")
            {
                txtIngre.Text = "米/パスタ";
                txtIngre.BackColor = Color.MistyRose;
                txtIngre.ForeColor = Color.Gray;
            }
        }

        private void txtCateg_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtCateg);
        }
        private void txtCateg_Enter(object sender, EventArgs e)
        {
            if (txtCateg.Text == "主菜/弁当etc")
            {
                txtCateg.Text = "";
            }
        }
        private void txtCateg_Leave(object sender, EventArgs e)
        {
            if (txtCateg.Text == "")
            {
                txtCateg.Text = "主菜/弁当etc";
                txtCateg.BackColor = Color.MistyRose;
                txtCateg.ForeColor = Color.Gray;
            }
        }

        private void txtRecipe_TextChanged(object sender, EventArgs e)
        {
            TextChecker.ColorChange(txtRecipe);
        }

        private void txtRecipe_Enter(object sender, EventArgs e)
        {
            if (txtRecipe.Text == "レシピなし")
            {
                txtRecipe.Text = "";
            }
        }

        private void txtRecipe_Leave(object sender, EventArgs e)
        {
            if (txtRecipe.Text == "")
            {
                txtRecipe.Text = "レシピなし";
                txtRecipe.BackColor = Color.MistyRose;
                txtRecipe.ForeColor = Color.Gray;
            }
        }

        private void dgvEdit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvEdit_CellClick(null, null);
        }




    }
}
