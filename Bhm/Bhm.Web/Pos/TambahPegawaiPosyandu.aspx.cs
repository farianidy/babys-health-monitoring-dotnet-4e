using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.PegawaisService;

namespace Bhm.Web.Pos
{
    public partial class TambahPegawaiPosyandu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            successNotificatonPanel.Visible = false;
        }

        protected void Tambah_Clicked(object sender, EventArgs e)
        {
            PegawaisServiceClient proxyPegawai = new PegawaisServiceClient();

            if (AdminTidak.Checked == true)
                proxyPegawai.InsertPegawai(Name.Text, Instance.Text, UserName.Text, Password.Text, false);
            else if (AdminYa.Checked == true)
                proxyPegawai.InsertPegawai(Name.Text, Instance.Text, UserName.Text, Password.Text, true);

            proxyPegawai.Close();
            successNotificatonPanel.Visible = true;
        }
    }
}