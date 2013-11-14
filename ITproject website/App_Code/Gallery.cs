using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Gallery
/// </summary>
public class Gallery
{
    //Attributes
    private int id;
    private DateTime created;
    private User createdBy;
    private string name;
    private string description;
    private List<Image> images;


	public Gallery(int id, DateTime created, User createdBy, string name, string description, List<Image> images)
	{
        this.id = id;
        this.created = created;
        this.createdBy = createdBy;
        this.name = name;
        this.description = description;
        this.images = images;
	}


    //Get image
    public Image getImage(int id)
    {
        //Check if value is valid
        if (id < 0 && id >= images.Count)
        {
            return null;
        }

        return images[id];
    }


    //Number if images in the gallery
    public int getImageCount()
    {
        return images.Count;
    }


    //Getters
    public int getId() { return id; }
    public DateTime getCreated() { return created; }
    public User getCreatedBy() { return createdBy; }
    public string getName() { return name; }
    public string getDescription() { return description; }
}