using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    private AdminMasterPage master_page = null;
    private Label error_label         = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.master_page = (AdminMasterPage)Page.Master;
        this.master_page.ShowError = false;
        this.error_label = (Label) error_message;
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload.HasFile)
        {
            if (FileUpload.FileName.Contains(".png") || FileUpload.FileName.Contains(".jpg"))
            {
                this.master_page.ShowError = false;
                this.error_label.Text = "";
                FileUpload.SaveAs(MapPath("~/uploads/" + FileUpload.FileName));
            }
            else
            {
                this.master_page.ShowError = true;
                this.error_label.Text = "Unknown Image Format, Please enter either a PNG or a JPEG image.";
            }

        }
    }
}
