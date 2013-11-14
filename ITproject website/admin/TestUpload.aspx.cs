using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {}

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload.HasFile)
        {
            FileUpload.SaveAs(MapPath("~/uploads/" + FileUpload.FileName));
        }
    }
}