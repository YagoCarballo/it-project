using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KVStore
/// </summary>
public class KVStore
{
    //Attributes
    SqlConnection db;

    //Constructor
	public KVStore(SqlConnection db)
	{
        this.db = db;
	}


    //Get a value from the database
    //Returns null if it doesn't exist
    public string get(string key)
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
        SqlCommand cmd = new SqlCommand("SELECT value FROM MidLin.kvstore WHERE key = @key", db);
        cmd.Parameters.AddWithValue("key", key);

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.HasRows)
            {
                rdr.Read();

                return rdr.GetString(0);
            }
            else
            {
                return null;
            }
        }
    }


    public bool set(string key, string value)
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

        //Use get function to check existence
        string curVal = get(key);
        SqlCommand cmd;
        if (curVal != null)
        {
            //Check if its already this value
            if (curVal == value)
            {
                //It's already this value, so just return
                return true;
            }

            cmd = new SqlCommand("UPDATE MidLin.kvstore SET value = @value WHERE key = @key", db);
        }
        else
        {
            cmd = new SqlCommand("INSERT INTO MidLin.kvstore ([key], [value]) VALUES (@key, @value)", db);
        }

        cmd.Parameters.AddWithValue("key", key);
        cmd.Parameters.AddWithValue("value", value);

        if (cmd.ExecuteNonQuery() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}