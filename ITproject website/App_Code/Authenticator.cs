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
    private string key;

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
        this.key = key;

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
        SqlCommand cmd = new SqlCommand("SELECT id FROM MidLin.users WHERE username = @username AND password = @password", db);
        cmd.Parameters.AddWithValue("username", username);
        cmd.Parameters.AddWithValue("password", sha256(password));

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
        if (user == null)
        {
            return false;
        }

        //Generate session key
        key = generateSessionKey();

        //Calculate expiry time
        DateTime expires = DateTime.Now;
        expires.AddDays(1);

        //Insert key into the database
        cmd = new SqlCommand("INSERT INTO sessions ([user], [key], [expires]) VALUES (@user, @key, @expires)", db);
        cmd.Parameters.AddWithValue("user", user.getId());
        cmd.Parameters.AddWithValue("key", key);
        cmd.Parameters.AddWithValue("expires", expires);

        if (cmd.ExecuteNonQuery() > 0)
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
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        SHA256Managed hashstring = new SHA256Managed();
        byte[] hash = hashstring.ComputeHash(bytes);
        string hashString = string.Empty;
        foreach (byte x in hash)
        {
            hashString += String.Format("{0:x2}", x);
        }
        return hashString;
    }

    private string generateSessionKey()
    {
        //Generate session key
        Random rng = new Random();
        string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        string key = "";
        for (int i = 0; i < 32; i++)
        {
            key += _chars.ElementAt(rng.Next(_chars.Length));
        }

        return key;
    }


    //Getters
    public User getUser() { return user; }
    public string getKey() { return key; }
}