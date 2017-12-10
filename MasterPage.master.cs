using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        users user = (users)Session["user"];

        if (user == null) {
            userOptions.Visible = false;
        } else
        {
            userName.Text = user.name + " (" + user.username + ")";
            loginBtn.Visible = false;
        }
    }

    protected void Buscar(object sender, EventArgs e)
    {

    }
}
