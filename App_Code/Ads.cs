using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Ads
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Ads : System.Web.Services.WebService
{
    List<Ad> ads = new List<Ad>();
    
    public Ads()
    {
        ads.Add(new Ad(1, "Tamo en pelota", "sport", 15));
        ads.Add(new Ad(2, "Planes ilimitados", "communication", 10));
        ads.Add(new Ad(3, "Reyes en pinturas", "home", 150));
        ads.Add(new Ad(4, "La mejor tinta del mercado", "office", 12));
        ads.Add(new Ad(5, "Planet Fitness", "sport", 50));
        ads.Add(new Ad(6, "Altice", "communication", 75));
        ads.Add(new Ad(7, "Comparte en las redes sociales", "social media", 20));
        ads.Add(new Ad(8, "Mac Ahorro", "food", 18));
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public Ad GetRandom()
    {
        int rand = new Random().Next(0, ads.Count);
        return ads[rand];
    }

    [WebMethod]
    public Ad Get(string type)
    {
        List<Ad> filtered = ads.Where(el => el.type == type).ToList();
        int rand = new Random().Next(0, filtered.Count);
        return filtered[rand];
    }

    [WebMethod]
    public List<Ad> GetAll()
    {
        return ads;
    }

}
