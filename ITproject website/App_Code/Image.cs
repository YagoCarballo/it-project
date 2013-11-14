using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Image
/// </summary>
public class Image
{
    //Attribute
    private int id;
    private User uploadedBy;
    private string name;
    private string link;
    private string description;
    private DateTime created;

	public Image(int id, User uploadedBy, string name, string link, string description, DateTime created)
	{
		this.id = id;
        this.uploadedBy = uploadedBy;
        this.name = name;
        this.link = link;
        this.description = description;
        this.created = created;
	}


    //Getters
    public int getId() { return id; }
    public User getUploadedBy() { return uploadedBy; }
    public string getName() { return name; }
    public string getLink() { return link; }
    public string getDescription() { return description; }
    public DateTime getCreated() { return created; }
}