using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Page
/// </summary>
public class Post
{
    //Attributes
    private int id;
    private User user;
    private string title;
    private string content;
    private string category;
    private DateTime created;

	public Post(int id, User user, string title, string content, string category, DateTime created)
	{
        this.id = id;
        this.user = user;
        this.title = title;
        this.content = content;
        this.category = category;
        this.created = created;
	}


    //Getters
    public int getId() { return id; }
    public User getUser() { return user; }
    public string getTitle() { return title; }
    public string getContent() { return content; }
    public string getCategory() { return category; }
    public DateTime getCreated() { return created; }


}