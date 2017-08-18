using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RecipeManagerForC_Sharp
{
    class NameConst
    {
        #region LogIn Constants

        public const int THIS_ROW = 0;
        public const int COL_PASSWORD = 1;
        public const int COL_AUTHORITY = 2;

        #endregion MainMenu Constants


        #region MainMenu Constants

        public const int COL_CATEGORY = 3;

        #endregion


        #region RecipeList Constant

        public const int COL_RECIPE = 0;
        public const int ROW_RECIPETEXT = 0;
        public const int COL_RECIPETEXT = 0;
        public const int COL_RECIPENO = 0;

        #endregion


        #region Recipe Constants

        public const int ROW_SELECTED = 0;
        public const int COL_NAME = 0;
        public const int COL_INGRE = 1;
        public const int COL_STYLE = 2;
        public const int COL_RRECIPE = 3;
        public const int COL_TIME = 4;
        public const int COL_CATEG = 5;
        public const int COL_RATE = 6;

        #endregion


        #region RecipeEdit Constants

        public const int EROW_SELECTED = 0;
        public const int ECOL_NUMBER = 0;
        public const int ECOL_NAME = 1;
        public const int ECOL_INGRE = 2;
        public const int ECOL_STYLE = 3;
        public const int ECOL_RECIPE = 5;
        public const int ECOL_TIME = 6;
        public const int ECOL_CATEG = 7;
        public const int ECOL_RATE = 8;

        #endregion
    }

}
