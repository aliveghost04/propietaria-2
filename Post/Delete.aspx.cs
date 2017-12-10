using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Post_Delete : System.Web.UI.Page
{
    TiendaEnLineaEntities entities = new TiendaEnLineaEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = getId();

        if (id <= 0)
        {
            Session["error"] = "Id del producto inválido";
            Response.Redirect("/Post/Default.aspx", true);
        }
    }

    protected void Submit(object sender, EventArgs e)
    {
        int id = getId();

        if (id > 0) {
            products product = entities.products
                .Where(el => el.id == id)
                .FirstOrDefault();

            entities.products.Remove(product);
            entities.SaveChanges();
            Session["success"] = "El producto ha sido eliminado con éxito";
            Response.Redirect("/Post/Default.aspx", true);
        } else
        {
            Session["error"] = "Id del producto inválido";
            Response.Redirect("/Post/Default.aspx", true);
        }
    }

    private int getId() {
        users user = (users)Session["user"];
        int id = 0;

        if (user == null)
        {
            Session["error"] = "Necesitas estas autenticado para realizar esta acción";
            Response.Redirect("/Login.aspx", true);
        }
        else
        {
            if (user.type == "administrator")
            {
                try
                {
                    id = Int32.Parse(Request.QueryString["id"]);

                    if (id <= 0)
                    {
                        Session["error"] = "Id de producto inválido";
                        Response.Redirect("/Post", true);
                    }
                }
                catch (Exception ex)
                {
                    Session["error"] = "Id de producto inválido";
                    Response.Redirect("/Post", true);
                }
            }
            else
            {
                Session["error"] = "Usted no tiene permiso para editar esta producto";
                Response.Redirect("/Post/Default.aspx", true);
            }
        }

        return id;
    }
}