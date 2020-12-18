
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace 毕业设计
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string loginSQL = string.Format("select * from sys_User where user_no = ('{0}') and user_passwd = ('{1}')", txtUserName.Text.Trim(), txtUserPassword.Text.Trim());
            DataTable dt = new DataTable();
            DataBase DB = new DataBase();
            dt = DB.RunSQL(loginSQL, dt);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }
    }
}