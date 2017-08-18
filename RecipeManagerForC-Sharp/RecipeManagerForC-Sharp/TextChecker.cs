using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RecipeManagerForC_Sharp
{
    class TextChecker
    {
        public static TextBox ColorChange(TextBox target)
        {
            if (string.IsNullOrEmpty(target.Text) || target.Text == "レシピなし")
            {
                target.BackColor = Color.MistyRose;
                target.ForeColor = Color.Gray;
                return target;
            }
            else
            {
                target.BackColor = Color.FloralWhite;
                target.ForeColor = Color.Black;
                return target;
            }
        }
    }
}
