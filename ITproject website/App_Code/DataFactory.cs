using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// This object is factory which retrieves information from the database
/// and returns it to a client.
/// 
/// Author: Adam Findlay
/// </summary>
public class DataFactory
{
    //Attributes
    private SqlConnection db;
    private Dictionary<int, User>userCache;


	public DataFactory(SqlConnection db)
	{
        this.db = db;

        userCache = new Dictionary<int,User>();
	}


    /**
     * Returns a user object from the database
     * Null is returned if no user was found with the given id
     */
    public User getUser(int id)
    {
        //Check if this user is in our cache
        User user;
        if (userCache.TryGetValue(id, out user))
        {
            //We found it cash, so just return
            return user;
        }

        if (db.State != ConnectionState.Open)
        {
            try
            {
                db.Open();
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        //Build query
        SqlCommand cmd = new SqlCommand("SELECT username, fname, lname, email FROM MidLin.users WHERE id = @id", db);
        cmd.Parameters.AddWithValue("id", id);

        string username;
        string fname;
        string lname;
        string email;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.Read())
            {
                username = rdr.GetString(0);
                fname = rdr.GetString(1);
                lname = rdr.GetString(2);
                email = rdr.GetString(3);

                rdr.Close();
            }
            else
            {
                return null;
            }
        }

        //Build query
        cmd = new SqlCommand("SELECT flag FROM MidLin.permissions WHERE user = @user", db);
        cmd.Parameters.AddWithValue("user", id);

        List<string> permissions = new List<string>();

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    permissions.Add(rdr.GetString(0));
                }
            }
        }

        //Add to cache and return
        user = new User(id, username, fname, lname, email, permissions);
        userCache.Add(id, user);
        return user;
    }



    /*
     * Returns an object representing a page in the database
     * Returns null if not found
     */
    public Page getPage(int id)
    {
        if (db.State != ConnectionState.Open)
        {
            try
            {
                db.Open();
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        //Build query
        SqlCommand cmd = new SqlCommand("SELECT id, [user], title, content, category, created FROM MidLin.pages WHERE id = @id", db);
        cmd.Parameters.AddWithValue("id", id);

        int userId;
        string title;
        string content;
        string category;
        DateTime created;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {

            int row = 0;
            if (rdr.HasRows)
            {
                rdr.Read();

                userId = rdr.GetInt32(1);
                title = rdr.GetString(2);
                content = rdr.GetString(3);
                category = rdr.GetString(4);
                created = rdr.GetDateTime(5);
            }
            else
            {
                return null;
            }
        }

        //Get our user object
        User user = getUser(userId);
        if (user != null)
        {
            //Create page object
            Page page = new Page(id, user, title, content, category, created);

            //Return
            return page;
        }
        else
        {
            return null;
        }
    }
}