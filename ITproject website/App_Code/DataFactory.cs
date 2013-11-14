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


    /*
     * Returns an object representing a page in the database
     * Returns null if not found
     */
    public Post getPost(int id)
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
        SqlCommand cmd = new SqlCommand("SELECT id, [user], title, content, category, created FROM MidLin.posts WHERE id = @id", db);
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
            Post post = new Post(id, user, title, content, category, created);

            //Return
            return post;
        }
        else
        {
            return null;
        }
    }


    /*
     * Returns an object which represents an image in the database
     * Returns null if now image with this id was found
     */
    public Image getImage(int id)
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
        SqlCommand cmd = new SqlCommand("SELECT uploadedBy, name, link, description, created FROM MidLin.images WHERE id = @id", db);
        cmd.Parameters.AddWithValue("id", id);

        int uploadedById;
        string name;
        string link;
        string description;
        DateTime created;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                rdr.Read();

                uploadedById = rdr.GetInt32(0);
                name = rdr.GetString(1);
                link = rdr.GetString(2);
                description = rdr.GetString(3);
                created = rdr.GetDateTime(4);
            }
            else
            {
                return null;
            }
        }

        //Get our user object
        User uploadedBy = getUser(uploadedById);
        if (uploadedBy != null)
        {
            //Create image object
            Image image = new Image(id, uploadedBy, name, link, description, created);

            //Return
            return image;
        }
        else
        {
            return null;
        }
    }


    /*
     * Returns an object which represents a gallery in the database
     * Returns null if none found with the given ID
     */
    public Gallery getGallery(int id)
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
        SqlCommand cmd = new SqlCommand("SELECT created, createdBy, name, description FROM MidLin.galleries WHERE id = @id", db);
        cmd.Parameters.AddWithValue("id", id);

        DateTime created;
        int createdById;
        string name;
        string description;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                rdr.Read();

                created = rdr.GetDateTime(0);
                createdById = rdr.GetInt32(1);
                name = rdr.GetString(2);
                description = rdr.GetString(3);
            }
            else
            {
                return null;
            }
        }

        //Get our user object
        User createdBy = getUser(createdById);
        if (createdBy == null)
        {
            return null;
        }

        //Get images that exist within our gallery
        cmd = new SqlCommand("SELECT MidLin.images.id, MidLin.images.uploadedby, MidLin.images.name, MidLin.images.link, MidLin.images.description, MidLin.images.created FROM MidLin.gallerie_image INNER JOIN MidLin.images ON MidLin.images.id = MidLin.gallerie_image.image WHERE (MidLin.gallerie_image.gallery = @id)", db);
        cmd.Parameters.AddWithValue("id", id);

        List<Image> images = new List<Image>();

        int imgId;
        int uploadedById;
        string link;

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                imgId = rdr.GetInt32(0);
                uploadedById = rdr.GetInt32(1);
                name = rdr.GetString(2);
                link = rdr.GetString(3);
                description = rdr.GetString(4);
                created = rdr.GetDateTime(5);

                images.Add(new Image(imgId, getUser(uploadedById), name, link, description, created));
            }
        }

        //Build object and return
        return new Gallery(id, created, createdBy, name, description, images);
    }
}