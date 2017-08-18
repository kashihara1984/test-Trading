using System;
using System.Text;

namespace RecipeManagerForC_Sharp
{
    public class SearchRecipeModel
    {
        public string cmbStyleValue { get; set; }
        public string cmbIngreValue { get; set; }
        public string cmbTimeValue { get; set; }
        public string cmbCategValue { get; set; }
        public string cmbRateValue { get; set; }
        public string txtKeyWordValue { get; set; }

        public string lblRnumberValue { get; set; }
        public string txtRnameValue { get; set; }
        public string txtIngreValue { get; set; }
        public string txtStyleValue { get; set; }
        public string txtRecipeValue { get; set; }
        public string txtTimeValue { get; set; }
        public string txtCategValue { get; set; }
        public string cmbEditRateValue { get; set; }

        public bool isOverTime { get; set; }

    }
}
