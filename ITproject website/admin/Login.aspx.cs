using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default2 : System.Web.UI.Page
{
    private AdminMasterPage master_page = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.master_page = (AdminMasterPage)Page.Master;

        loginBtn.Attributes.Add("onclick", "return LogIn_Btn_Click(this)");
    }

    protected void LogIn_Btn_Click(object sender, EventArgs e)
    {
        Session["test"] = true;
        master_page.LoggedIn = true;
        Response.Redirect("http://google.com", true);
    }
}