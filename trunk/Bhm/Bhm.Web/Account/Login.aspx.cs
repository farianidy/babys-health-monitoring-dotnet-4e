using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

using Bhm.Web.PegawaisService;

namespace Bhm.Web.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LogIn_Clicked(object sender, EventArgs e)
        {
            PegawaisServiceClient proxyPegawai = new PegawaisServiceClient();

            PegawaiData user = proxyPegawai.CheckLogin(UserName.Text, Password.Text);
            if (user != null)
            {
                Session["UserActive"] = user;

                if (user.instansi == "Dinkes")
                    Response.Redirect("~/DinasKes/Dinkes.aspx");
                else if (user.instansi == "Dispencapil")
                    Response.Redirect("~/Dispen/Dispencapil.aspx");
                else if (user.instansi == "Posyandu")
                    Response.Redirect("~/Pos/Posyandu.aspx");
            }

            proxyPegawai.Close();
        }
    }
}
