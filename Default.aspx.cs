using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    TiendaEnLineaEntities entities = new TiendaEnLineaEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["q"];
        if (query == "" || query == null)
        {
            items.DataSource = entities.products.ToList();
            searchResult.Visible = false;
        }
        else
        {
            items.DataSource = entities.products
                .Where(el => el.name.Contains(query)).ToList();

            searchResult.Visible = true;
            searchTerm.Text = query;
        }

        items.DataBind();

        string error = (string)Session["error"];

        if (error != null && error != "")
        {
            errorPanel.Visible = true;
            errorMessage.Text = error;
            Session["error"] = null;
        }
        else
        {
            errorPanel.Visible = false;
        }

        string success = (string)Session["success"];

        if (success != null && success != "")
        {
            successPanel.Visible = true;
            successMessage.Text = success;
            Session["success"] = null;
        }
        else
        {
            successPanel.Visible = false;
        }
    }
}