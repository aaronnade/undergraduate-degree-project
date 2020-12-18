using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 毕业设计.backGroundAdmin
{
    public partial class userGroupManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                gv_data_bind();
            }
        }

        protected void btnAddUserGroup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/backGroundAdmin/addNewUserGroup.aspx");
        }

        protected void gvGroup_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_delete")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string group_name = gvGroup.Rows[rowIndex].Cells[0].Text;
                string deleteSQL = string.Format("delete from user_group where user_group_name = ('{0}')", group_name);
                DataBase db = new DataBase();
                db.RunSQL(deleteSQL);
                gv_data_bind();
            }
        }

        protected void gv_data_bind()
        {
            string searchSQL = "select * from user_group";
            DataSet ds = new DataSet();
            DataBase db = new DataBase();

            ds = db.RunSQL(searchSQL, ds);
            gvGroup.DataSource = ds.Tables[0];
            gvGroup.DataBind();
        }
    }
}