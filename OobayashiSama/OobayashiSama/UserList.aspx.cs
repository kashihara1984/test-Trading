using OobayashiSama.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OobayashiSama
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    SetData();
                }
                catch (Exception ex)
                {
                    // TODO：例外どうしよう？
                    throw ex;
                }

            }
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                UsersBL bl = new UsersBL();
                bl.CSVImport();
                SetData();
            }
            catch (Exception ex)
            {
                // TODO：例外どうしよう？
                throw ex;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UsersBL bl = new UsersBL();
                string name = txtName.Text.Trim();
                DataTable dt = bl.GetUsers(name);
                UserGV.DataSource = dt;
                UserGV.DataBind();
                Session["users"] = dt;
            }
            catch (Exception ex)
            {
                // TODO：例外どうしよう？
                throw ex;
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                UsersBL bl = new UsersBL();
                DataTable dt = Session["users"] as DataTable;
                if (dt != null)
                {
                    string filePath = bl.CSVCreate(dt);

                    // ファイル名だけを抽出
                    string fileName = Path.GetFileName(filePath);

                    // ダウンロード
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}", fileName));
                    Response.Flush();
                    Response.WriteFile(filePath);
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                // TODO：例外どうしよう？
                throw ex;
            }
        }

        /// <summary>
        /// データをセットする
        /// </summary>
        private void SetData()
        {
            UsersBL bl = new UsersBL();
            DataTable dt = bl.GetUsers();
            UserGV.DataSource = dt;
            UserGV.DataBind();
            Session["no"] = null;
            Session["users"] = dt;


        }

        protected void UserGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // 削除
            if (e.CommandName == "Delete")
            {
                try
                {
                    // 主キー（番号列）の値を取得
                    int no = Int32.Parse((string)e.CommandArgument);

                    // 削除処理
                    UsersBL blDel = new UsersBL();
                    blDel.DelUser(no);

                    SetData();
                }
                catch (Exception ex)
                {
                    // TODO：例外どうしよう？
                    throw ex;
                }
            }
            // 編集
            else if (e.CommandName == "Edit") 
            {
                try
                {
                    // 主キー（番号列）の値を取得
                    int no = Int32.Parse((string)e.CommandArgument);
                    Session["no"] = no;

                    Response.Redirect("UserEdit.aspx", false);
                }
                catch (Exception ex)
                {
                    // TODO：例外どうしよう？
                    throw ex;
                }
            }

        }



        protected void UserGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //???
        }

        protected void UserGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //???
        }

    }
}