using OobayashiSama.BusinessLogic;
using OobayashiSama.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OobayashiSama
{
    public partial class UserEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                try
                {
                    // 番号取得
                    int no = (int)Session["no"];

                    UsersBL bl = new UsersBL();
                    UserModel dispInfo = bl.GetUser(no);

                    lblNo.Text = dispInfo.ID.ToString();
                    txtName.Text = dispInfo.Name;
                    txtPosition.Text = dispInfo.Position;
                    lblValid.Text = "";
                }
                catch (Exception ex)
                {
                    // TODO：例外処理
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 更新ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try 
            {
                if (IsUserValid()) 
                {
                    UserModel model = new UserModel();
                    model.ID = (int)Session["no"];
                    model.Name = txtName.Text;
                    model.Position = txtPosition.Text;
                    model.UpdDate = DateTime.Now;

                    UsersBL bl = new UsersBL();
                    bl.UpdUser(model);

                    Response.Redirect("UserList.aspx", false);
                }
            }
            catch (Exception ex) 
            {
                // TODO：例外処理
                throw ex;
            }
        }

        /// <summary>
        /// 一覧へ戻るボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserList.aspx", false);
        }

        /// <summary>
        /// 検証チェック
        /// </summary>
        /// <returns></returns>
        private bool IsUserValid() 
        { 
            lblValid.Text = "";
            bool isEnableData = true;

            // 名前の入力
            if (string.IsNullOrEmpty(txtName.Text.Trim())) 
            {
                isEnableData = false;
                lblValid.Text += "・名前が入力されていません"; 
            }
            // 役職の入力
            if (string.IsNullOrEmpty(txtPosition.Text.Trim())) 
            {
                lblValid.Text += !isEnableData ? "<br />" : "";
                isEnableData = false;
                lblValid.Text += "・役職が入力されていません";
            }
            return isEnableData; 
        }
    }
}