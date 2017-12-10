using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    TiendaEnLineaEntities entities = new TiendaEnLineaEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        var x = (string) Session["error"];
        users user = (users)Session["user"];

        if (x != "" && x != null) {
            errorMessage.Text = (string) Session["error"];
            errorLabel.Visible = true;
            Session["error"] = "";
        }
        
        if (Request.Form["action"] == "logout")
        {
            Session["user"] = null;
            Response.Redirect("/Default.aspx", true);
        }

        if (user != null)
        {
            Response.Redirect("/Default.aspx", true);
        }


        this.Master.FindControl("navbar").Visible = false;
    }

    public void SubmitLogin(object sender, System.EventArgs e) {
        users user = (
            from el in entities.users
                      where el.password == inputPassword.Text &&
                      el.email == inputEmail.Text &&
                      el.status == 1
                      select el
        ).FirstOrDefault();

        if (user == null)
        {
            Session["error"] = "Usuario y/o contraseña inválida";
            Server.Transfer("Login.aspx");
        }
        else {
            Session["user"] = user;
            Response.Redirect("/Default.aspx", true);
        }
    }
}