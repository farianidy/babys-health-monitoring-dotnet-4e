﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhm.Web.Dispen
{
    public partial class Pendaftaran : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            successNotificatonPanel.Visible = false;
        }

        protected void Tambah_Clicked(object sender, EventArgs e)
        {
            successNotificatonPanel.Visible = true;
        }
    }
}