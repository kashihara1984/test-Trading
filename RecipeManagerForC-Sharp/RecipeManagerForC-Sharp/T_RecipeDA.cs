using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecipeManagerForC_Sharp
{
    public class T_RecipeDA
    {
        DbManager dbMng = DbManager.CreateOnce;

        
        private string LoginSql = @"
        SELECT 
            UserID, Pass, Authority 
        FROM 
            T_LogIn";

        public DataTable GetAccount()
        {
                DataTable dtAccount = dbMng.SelectSql(LoginSql, null);
                return dtAccount;
        }

        private string MainSql = @"
        SELECT TOP 8 
            ItemName, MainIngredient, Style, Category, LastUsedDate 
        FROM 
            T_Recipe 
        ORDER BY 
            LastUsedDate DESC";

        public DataTable MainShown()
        {
                DataTable dtMainShown = dbMng.SelectSql(MainSql, null);
                return dtMainShown;
        }

        private string ListSql = @"
        SELECT 
            ItemNo, ItemName, MainIngredient, Style, 
            CONVERT(VARCHAR(5),CookTime, 108) AS CookTime, Category, Stars 
        FROM 
            T_Recipe LEFT JOIN T_Rate 
        ON 
            T_Recipe.Rate = T_Rate.Numbers 
        WHERE 
            1 = 1 " ;

        public DataTable ListShown(SearchRecipeModel model)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();

            if (model != null) 
            {
                if (!string.IsNullOrEmpty(model.cmbStyleValue)) 
                {
                    ListSql += " AND Style = @Style ";
                    paramList.Add(new SqlParameter("@Style", model.cmbStyleValue));
                }

                if (!string.IsNullOrEmpty(model.cmbIngreValue)) 
                {
                    ListSql += " AND MainIngredient = @Ingre ";
                    paramList.Add(new SqlParameter("@Ingre", model.cmbIngreValue));
                }
                if (!string.IsNullOrEmpty(model.cmbCategValue))
                {
                    ListSql += " AND Category = @Category ";
                    paramList.Add(new SqlParameter("@Category", model.cmbCategValue));
                }
                if (!string.IsNullOrEmpty(model.cmbTimeValue))
                {
                    string hikaku = "<=";
                    if (model.isOverTime) 
                    {
                        hikaku = ">=";
                    }
                    ListSql += " AND CookTime " + hikaku + " @Time ";
                    SqlParameter time = new SqlParameter("@Time", model.cmbTimeValue);
                    time.SqlDbType = SqlDbType.Time;
                    paramList.Add(time);
                }
                if (!string.IsNullOrEmpty(model.cmbRateValue))
                {
                    ListSql += " AND Rate >= @Rate ";
                    paramList.Add(new SqlParameter("@Rate", model.cmbRateValue));
                }
                if (!string.IsNullOrEmpty(model.txtKeyWordValue))
                {
                    ListSql += " AND T_Recipe.Recipe LIKE @KeyWord ";
                    paramList.Add(new SqlParameter("@KeyWord", "%" + model.txtKeyWordValue + "%"));
                }
            }

            ListSql += @"
            ORDER BY  
                LastUsedDate ASC";

                DataTable dtListShown = dbMng.SelectSql(ListSql, paramList);
                return dtListShown;
        }

        private string PreviewSql = @"
        SELECT 
            Recipe 
        FROM 
            T_Recipe 
        WHERE 
            ItemNo = @ItemNo";

        public DataTable ListPreview(string ItemNo)
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemNo", ItemNo));
                DataTable dtListPreview = dbMng.SelectSql(PreviewSql, objParms);
                return dtListPreview;
        }
        
        private string RecipeSQL = @"
        SELECT
            ItemName, MainIngredient, Style, Recipe,
            CONVERT(VARCHAR(5), CookTime, 108) as CookTime, Category, Rate
        FROM
            T_Recipe
        WHERE
            ItemNo = @ItemNo";

        public static string ItemNumber;

        public DataTable RecipeShown()
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemNo", ItemNumber));
                DataTable dtRecipeShown = dbMng.SelectSql(RecipeSQL, objParms);
                return dtRecipeShown;
        }

        public string NowYMD = DateTime.Now.ToString("yyyy-MM-dd");
        private string UpdateSql = @"
        UPDATE 
            T_Recipe 
        SET 
            LastUsedDate = @NowYMD 
        WHERE 
            ItemNo = @ItemNumber";

        public void RecipeUpdate()
        {

                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemNumber", ItemNumber));
                objParms.Add(new SqlParameter("@NowYMD", NowYMD));
                dbMng.RunSql(UpdateSql, objParms);
                return;
        }

        private string RecipeEditSql = @"
        UPDATE 
            T_Recipe 
        SET 
            Recipe = @UpdatedRecipe, 
            Rate = @UpdatedRate 
        WHERE 
            ItemNo = @ItemNumber";
        public void RecipeEdit(string Recipe, object Rate)
        {

                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@UpdatedRate", Rate));
                objParms.Add(new SqlParameter("@UpdatedRecipe", Recipe));
                objParms.Add(new SqlParameter("@ItemNumber", ItemNumber));
                dbMng.RunSql(RecipeEditSql, objParms);
                return;
        }

        private string EditShownSql = @"
        SELECT 
            ItemNo, ItemName, MainIngredient, Style, LastUsedDate, 
            Recipe, CookTime, Category, Rate 
        FROM 
            T_Recipe 
        WHERE 
            1 = 1 
        ORDER BY  
            ItemNo ASC";

        public DataTable EditShown()
        {
                DataTable dtEditShown = dbMng.SelectSql(EditShownSql, null);
                return dtEditShown;
        }

        private string EditSelectSql = @"
        SELECT
            ItemNo, ItemName, MainIngredient, Style, LastUsedDate, 
            Recipe, CookTime, Category, Rate
        FROM 
            T_Recipe 
        WHERE 
            ItemNo = @ItemNumber";
        public DataTable EditSelect()
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemNumber", ItemNumber));
                DataTable dtEditSelect = dbMng.SelectSql(EditSelectSql, objParms);
                return dtEditSelect;
        }

        private string EditInsertSql = @"
        INSERT INTO T_Recipe
            (ItemName, MainIngredient, Style, Recipe,
            CookTime, Category, Rate)
        VALUES 
            (@ItemName, @MainIngredient, @Style, @Recipe, 
            @CookTime, @Category, @Rate)";

        public void EditInsert(SearchRecipeModel model)
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemName", model.txtRnameValue));
                objParms.Add(new SqlParameter("@MainIngredient", model.txtIngreValue));
                objParms.Add(new SqlParameter("@Style", model.txtStyleValue));
                objParms.Add(new SqlParameter("@Recipe", model.txtRecipeValue));
                objParms.Add(new SqlParameter("@CookTime", model.txtTimeValue));
                objParms.Add(new SqlParameter("@Category", model.txtCategValue));
                objParms.Add(new SqlParameter("@Rate", model.cmbEditRateValue));

                dbMng.RunSql(EditInsertSql, objParms);
        }

        private string EditUpdateSql = @"
        UPDATE 
            T_Recipe
        SET 
            ItemName = @ItemName, MainIngredient = @MainIngredient,
            Style = @Style, Recipe = @Recipe, CookTime = @CookTime,
            Category = @Category, Rate = @Rate
        WHERE 
            ItemNo = @lblRnumber ";
        public void EditUpdate(SearchRecipeModel model)
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@ItemName", model.txtRnameValue));
                objParms.Add(new SqlParameter("@MainIngredient", model.txtIngreValue));
                objParms.Add(new SqlParameter("@Style", model.txtStyleValue));
                objParms.Add(new SqlParameter("@Recipe", model.txtRecipeValue));
                objParms.Add(new SqlParameter("@CookTime", model.txtTimeValue));
                objParms.Add(new SqlParameter("@Category", model.txtCategValue));
                objParms.Add(new SqlParameter("@Rate",model.cmbEditRateValue));
                objParms.Add(new SqlParameter("@lblRnumber", model.lblRnumberValue));
                dbMng.RunSql(EditUpdateSql, objParms);
        }

        private string EditDeleteSql = @"
        DELETE FROM 
            T_Recipe 
        WHERE 
            ItemNo = @lblRnumber";
        public void EditDelete(SearchRecipeModel model)
        {
                List<SqlParameter> objParms = new List<SqlParameter>();
                objParms.Add(new SqlParameter("@lblRnumber", model.lblRnumberValue));
                dbMng.RunSql(EditDeleteSql, objParms);
        }
    }
}

