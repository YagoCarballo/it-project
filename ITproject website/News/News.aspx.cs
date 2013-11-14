using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News_News : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Open database connection
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["midlindb"].ConnectionString);
        conn.Open();
        DataFactory dataFac = new DataFactory(conn);

        Page page = dataFac.getPage(1);

        title.Text = page.getTitle();
        content.Text = page.getContent();
        author.Text = "by " + page.getUser().getFullName() + " on " + page.getCreated().Date;
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);


    }
}