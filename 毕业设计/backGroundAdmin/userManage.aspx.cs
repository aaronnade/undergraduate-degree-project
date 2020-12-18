using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 毕业设计.backGroundAdmin
{
    public partial class userManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                gvUser_data_bind();
            }
        }

        protected void gvUser_data_bind()
        {
            string searchSQL = "select * from sys_User";
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            ds = db.RunSQL(searchSQL, ds);
            gvUser.DataSource = ds.Tables[0];
            gvUser.DataBind();
        }

        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "btn_delete")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string user_no = gvUser.Rows[rowIndex].Cells[0].Text;
                string deleteSQL = string.Format("delete from sys_User where user_no = ('{0}')", user_no);
                DataBase db = new DataBase();
                db.RunSQL(deleteSQL);
                gvUser_data_bind();
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/backGroundAdmin/userAdd.aspx");
        }
    }
}