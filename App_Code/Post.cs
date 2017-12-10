using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Data;

/// <summary>
/// Summary description for Post
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Post : System.Web.Services.WebService
{
    List<PostFile> posts = new List<PostFile>();

    public Post()
    {
        posts.Add(new PostFile(1, "Pantalon", "Pantalon de tela", 1200, true));
        posts.Add(new PostFile(2, "Blusa", "Talla 14", 1200, true));
        posts.Add(new PostFile(3, "Samsung S8", "Compra el nuevo Galaxy S8", 1200, true));
        posts.Add(new PostFile(4, "Tablet iRulu", "Tableta perfecta para niños", 1200, true));
        posts.Add(new PostFile(5, "iPhone 6", "Tiene la camara averiada", 1200, true));
        posts.Add(new PostFile(6, "Laptop Toshiba", "La vendo porque quiero una nueva", 1200, true));
        posts.Add(new PostFile(7, "Moto G5", "Recien importado", 1200, true));
        posts.Add(new PostFile(8, "LG G5", "Celular como nuevo", 1200, true));
        posts.Add(new PostFile(9, "Kia Picanto", "Vehículo en excelentes condiciones", 312000, true));
        posts.Add(new PostFile(10, "Prueba", "prueba", 1200, true));
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<PostFile> Get()
    {
        return posts;
    }

    [WebMethod]
    public PostFile Register(int id, string name, string description, double price, int available)
    {   

        PostFile post = new PostFile(id, name, description, price, available == 1);
        posts.Add(post);
        return post;
    }

}
