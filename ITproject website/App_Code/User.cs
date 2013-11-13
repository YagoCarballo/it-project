using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This object represents a user in the database
/// 
/// Author: Adam Findlay
/// </summary>
public class User
{
    //Attributes
    private int id;
    private string username;
    private string fname;
    private string lname;
    private string email;
    private List<string> permissions;

	public User(int id, string username, string fname, string lname, string email, List<string> permissions)
	{
        this.id = id;
        this.username = username;
        this.fname = fname;
        this.lname = lname;
        this.email = email;
        this.permissions = permissions;
	}


    public bool checkPermission(string flag)
    {
        for (int i = 0; i < permissions.Count; i++)
        {
            if (permissions[i] == flag)
            {
                return true;
            }
        }

        //If we've reached here, the permission was not found
        return false;
    }


    //Get full name
    public string getFullName()
    {
        return fname + " " + lname;
    }


    //Main getters
    public int getId() {   return id; }
    public string getUsername() { return username; }
    public string getFname() { return fname; }
    public string getLname() { return lname; }
    public string getEmail() { return email; }

}