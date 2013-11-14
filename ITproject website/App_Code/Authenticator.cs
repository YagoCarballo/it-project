using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Authenticator
/// </summary>
public class Authenticator
{
    //Attributes
    private SqlConnection db;
    private DataFactory dataFac;
    private User user;

	public Authenticator(SqlConnection db)
	{
        this.db = db;
        dataFac = new DataFactory(db);
        user = null;
	}


    //Check a session key
    public bool checkSessionKey(string key)
    {
        if (db.State != ConnectionState.Open)
        {
            try
            {
                db.Open();
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        //Build query
        DateTime now = DateTime.Now;
        SqlCommand cmd = new SqlCommand("SELECT user FROM MidLin.sessions WHERE key = @key AND expires < @now", db);
        cmd.Parameters.AddWithValue("key", key);
        cmd.Parameters.AddWithValue("now", now);

        int userId;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                rdr.Read();

                userId = rdr.GetInt32(0);

                rdr.Close();
            }
            else
            {
                return false;
            }
        }

        //Fill the private user object with the user specified
        user = dataFac.getUser(userId);

        //Check it was found
        if (user != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Check login credentials
    public bool checkLoginCredentials(string username, string password)
    {
        if (db.State != ConnectionState.Open)
        {
            try
            {
                db.Open();
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        //Build query
        SqlCommand cmd = new SqlCommand("SELECT user FROM MidLin.users WHERE username = @username AND password @password", db);
        cmd.Parameters.AddWithValue("username", username);
        cmd.Parameters.AddWithValue("now", sha256(password));

        int userId;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                rdr.Read();

                userId = rdr.GetInt32(0);

                rdr.Close();
            }
            else
            {
                return false;
            }
        }

        //Get user
        user = dataFac.getUser(userId);
        if (user != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Sha hash method
    private string sha256(string input)
    {
        byte[] bytes = new byte[input.Length * sizeof(char)];
        System.Buffer.BlockCopy(input.ToCharArray(), 0, bytes, 0, bytes.Length);
        byte[] result;

        using (SHA256 shaM = new SHA256Managed())
        {
            result = shaM.ComputeHash(bytes);
            ASCIIEncoding ascii = new ASCIIEncoding();
            return ascii.GetString(result, 0, 256);
        }
    }
}