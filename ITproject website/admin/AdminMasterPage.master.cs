using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_MasterPage : System.Web.UI.MasterPage
{
    bool loggedIn = true;
    protected void Page_Init(object sender, EventArgs e)
    { 
        if (!loggedIn) {
            Response.Redirect("~/admin/Login.aspx", true);
        }
    }
}
