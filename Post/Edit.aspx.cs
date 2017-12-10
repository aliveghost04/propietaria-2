using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Post_Edit : System.Web.UI.Page
{
    TiendaEnLineaEntities entities = new TiendaEnLineaEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        users user = (users)Session["user"];
        products product = null;

        int id = getId();

        if (!IsPostBack)
        {
            if (id > 0)
            {
                product = entities.products
                    .Where(el => el.id == id)
                    .FirstOrDefault();

                inputId.Value = product.id.ToString();
                txtName.Value = product.name;
                txtDetails.Value = product.details;
                txtPrice.Value = product.unit_price.ToString();
                txtCharacteristics.Value = product.characteristics;

            }
            else
            {
                Session["error"] = "Id de producto inválido";
                Response.Redirect("/Post", true);
            }
        }
    }
    
    protected void Submit(object sender, EventArgs e)
    {
        int id = getId();
        products product = null;

        if (id > 0)
        {
            product = entities.products
                                .Where(el => el.id == id)
                                .FirstOrDefault();

            product.name = txtName.Value;
            product.details = txtDetails.Value;
            product.characteristics = txtCharacteristics.Value;
            decimal price = 0;

            Decimal.TryParse(txtPrice.Value, out price);

            product.unit_price = price;

            entities.SaveChanges();
            Session["success"] = "Producto actualizado exitosamente";
            Response.Redirect("/Post", true);

        } else
        {
            Session["error"] = "Id de producto inválido";
            Response.Redirect("/Post", true);
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