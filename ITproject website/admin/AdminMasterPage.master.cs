using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMasterPage : System.Web.UI.MasterPage
{
    private bool showError = false;
    bool loggedIn = true;
    protected void Page_Init(object sender, EventArgs e)
    {
        this.ShowError = false;

        if (!loggedIn) {
            Response.Redirect("~/admin/Login.aspx", true);
        }
    }

    public void displayError (bool display) {
        this.FindControl("error_box").Visible = display;
    }



    public bool ShowError { get { return showError; } set { showError = value; ErrorContent.Visible = showError; } } 
}
