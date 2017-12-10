using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ad
/// </summary>
public class Ad
{
    public string type { get; set; }
    public string name { get; set; }
    public int views { get; set; }
    public int id { get; set; }

    public Ad()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Ad(int id, string name, string type, int views) {
        this.id = id;
        this.name = name;
        this.type = type;
        this.views = views;
    }
}