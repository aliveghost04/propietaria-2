using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Password
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Password : System.Web.Services.WebService
{

    List<string> ads = new List<string>();
    List<string> words = new List<string>() {
        "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","!","@","#","$","%","*","(",")","_","-","+"
    };
    Random rnd;

    public Password()
    {
        rnd = new Random();
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    private string randomString(int length)
    {
        string word = "";
        int longitud = words.Count;

        for (int x = 0; x <= length; x++)
        {
            word += words[rnd.Next(0, longitud)];
        }

        return word;
    }

    [WebMethod]
    public string GetRandomPassword(string maxLength)
    {
        int length;

        Int32.TryParse(maxLength, out length);
        if (length < 6)
        {
            length = 6;
        }
        return randomString(rnd.Next(6, length));
    }

    [WebMethod]
    public string GetRandomLengthPassword()
    {
        return randomString(rnd.Next(6, 24));
    }
}
