using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 毕业设计.backGroundAdmin
{
    public partial class userAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string searchGroupSQL = "select user_group_name from user_group";
                DataBase db = new DataBase();
                DataSet ds = new DataSet();
                ds = db.RunSQL(searchGroupSQL, ds);
                ddlUserGroup.DataSource = ds.Tables[0];
                ddlUserGroup.DataBind();
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            string userNo = txtUserNo.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string userPasswd = txtUserPasswd.Text.Trim();

            //string insertSQL = 
        }
    }
}