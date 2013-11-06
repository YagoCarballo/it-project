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
        SqlConnection conn = new SqlConnection();
        string connString = ConfigurationManager.ConnectionStrings["midlindb"].ConnectionString;   
        conn.ConnectionString = connString;
        conn.Open();



        

        // Prepare and execute SQL command
        SqlCommand comm = new SqlCommand("SELECT [test] FROM [Table]", conn);
        SqlDataAdapter adapter = new SqlDataAdapter(comm);

        // Set up a 'DataReader' object
        SqlDataReader Table = comm.ExecuteReader();

        // Now insert each row in 'results' into 'panelFilms'
        while (Table.Read())
        {
            Label title = new Label();
            title.Text = Table[0].ToString();
            title.Width = 400;
            pagePanel.Controls.Add(title);
        }    


       //  SELECT [test] FROM [Table]


        // Close connection once we're finished with it
        conn.Close();
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        

    }
}