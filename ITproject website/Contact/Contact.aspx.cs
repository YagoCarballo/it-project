using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;             // Needed for ConfigurationManager class
using System.Data;                      // Needed for DataTable
using System.Data.SqlClient;            // Needed for SqlConnection

public partial class About_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Open database connection
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["midlindb"].ConnectionString);
        conn.Open();
        DataFactory dataFac = new DataFactory(conn);

        Page page = dataFac.getPage(2);

        title.Text = page.getTitle();
        content.Text = page.getContent();
        author.Text = "by " + page.getUser().getFullName() + " on " + page.getCreated().Date;

    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        

    }
}