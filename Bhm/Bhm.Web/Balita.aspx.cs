﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhm.Web
{
    public partial class Balita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Lihat_Clicked(object sender, EventArgs e)
        {
            Response.Redirect("~/DetilBalita.aspx?Balita=" + BalitaTb.Text + "&Ayah=" + Ayah.Text + "&Ibu=" + Ibu.Text);
        }
    }
}