using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.PegawaisService;

namespace Bhm.Web
{
    public partial class Posyandu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PegawaiData user = (PegawaiData)Session["UserActive"];
            if (user == null)
                Response.Redirect("~/");
            else
            {
                PanelMemberLogin.Visible = true;
                UserLabel.Text = "Selamat datang, " + user.namaPgw;
            }

            if (user.isAdmin == true)
            {
                NavigationMenuAdmin.Visible = true;
                NavigationMenu.Visible = false;
            }
            else
            {
                NavigationMenuAdmin.Visible = false;
                NavigationMenu.Visible = true;
            }
        }

        protected void LogOut_Clicked(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/");
        }
    }
}