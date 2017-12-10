using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Post_Create : System.Web.UI.Page
{
    TiendaEnLineaEntities entities = new TiendaEnLineaEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit(object sender, EventArgs e)
    {
        int price;

        try
        {
            price = Int32.Parse(txtPrice.Text);
        } catch (Exception ex) {
            price = 0;
        }

        entities.products.Add(new products() {
            name = txtName.Text,
            details = txtDetails.Text,
            characteristics = txtCharacteristics.Text,
            unit_price = price
        });

        entities.SaveChanges();

        Session["success"] = "Su anuncio ha sido creado exitosamente";
        Response.Redirect("/Post", true);
    }
}