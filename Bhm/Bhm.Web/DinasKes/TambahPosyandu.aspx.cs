using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.PosyandusService;

namespace Bhm.Web.DinasKes
{
    public partial class TambahPosyandu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            successNotificatonPanel.Visible = false;
        }

        protected void Tambah_Clicked(object sender, EventArgs e)
        {
            PosyandusServiceClient proxyPosyandu = new PosyandusServiceClient();

            proxyPosyandu.InsertPosyandu(Name.Text, Desa.Text, Kecamatan.Text, Kabupaten.Text, Provinsi.Text);

            proxyPosyandu.Close();
            successNotificatonPanel.Visible = true;
        }
    }
}