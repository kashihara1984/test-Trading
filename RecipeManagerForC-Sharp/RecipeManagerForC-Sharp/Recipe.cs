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
    public partial class Recipe : Form
    {
        public Recipe()
        {
            InitializeComponent();
        }

        DataTable dtRecipe = new DataTable();

        private void Recipe_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void Recipe_Shown(object sender, EventArgs e)
        {
            try
            {
                dtRecipe = new T_RecipeDA().RecipeShown();
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }

            lblName.Text =  dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_NAME].ToString();
            lblIngre.Text = dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_INGRE].ToString();
            lblStyle.Text = dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_STYLE].ToString();
            lblTime.Text =  dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_TIME].ToString();
            lblCateg.Text = dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_CATEG].ToString();

            DataTable dtRate = new DataTable();
            dtRate.Columns.Add("レート");
            dtRate.Columns.Add("Rate");
            dtRate.Rows.Add("なし", "");
            dtRate.Rows.Add("★", "1");
            dtRate.Rows.Add("★★", "2");
            dtRate.Rows.Add("★★★", "3");
            dtRate.Rows.Add("★★★★", "4");
            dtRate.Rows.Add("★★★★★", "5");

            cmbRate.DataSource = dtRate;
            cmbRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRate.ValueMember = "Rate";
            cmbRate.DisplayMember = "レート";
            cmbRate.SelectedValue = dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_RATE].ToString();

            if (dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_RRECIPE].ToString() == null)
            {
                txtRecipe.Text = "レシピなし";
            }
            else
            {
                txtRecipe.Text = dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_RRECIPE].ToString();
            }

            txtRecipe.ReadOnly = false;
            txtRecipe.ScrollBars = ScrollBars.Vertical;

            if (dtRecipe.Rows[NameConst.ROW_SELECTED].ItemArray[NameConst.COL_CATEG].ToString() == "外食")
            {
                btnCommit.Text = "外食する";
                btnCommit.BackColor = Color.LightBlue;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            RecipeList RList = new RecipeList();
            RList.Show();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                T_RecipeDA Rda = new T_RecipeDA();
                Rda.RecipeUpdate();
                MessageBox.Show("最後に調理した日時が更新されました。" + Environment.NewLine +
                                "追記情報は編集ボタンで更新してください。");
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                T_RecipeDA Rda = new T_RecipeDA();
                Rda.RecipeEdit(txtRecipe.Text, cmbRate.SelectedValue);
                MessageBox.Show("レシピを更新しました！");
            }
            catch (Exception)
            {
                MessageBox.Show("読み込みに失敗しました。" + Environment.NewLine +
                    "詳しくは管理者までお問い合わせください。");
                Application.Exit();
            }
        }


    }
}
