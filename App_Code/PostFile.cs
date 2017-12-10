using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PostFile
/// </summary>
public class PostFile
{
    public string details { get; set; }
    public string name { get; set; }
    public int id { get; set; }
    public double price {get; set;}
    public bool available { get; set; }

    public PostFile(int id, string name, string details, double price, bool available)
    {
        this.available = available;
        this.name = name;
        this.id = id;
        this.price = price;
        this.details = details;
        //
        // TODO: Add constructor logic here
        //
    }

    public PostFile() { }
}