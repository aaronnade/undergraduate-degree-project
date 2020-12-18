using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 毕业设计.backGroundAdmin
{
    public partial class addNewUserGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string insertSQL = string.Format("insert into user_group values('{0}', '{1}')", txtGroupName.Text.Trim(), txtGroupDesc.Text.Trim());
            DataBase db = new DataBase();
            db.RunProc(insertSQL);
        }
    }
}