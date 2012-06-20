using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.KegiatansService;
using Bhm.Web.PosyandusService;
using Bhm.Web.BalitasService;

namespace Bhm.Web.Pos
{
    public partial class IkutKegiatan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            successNotificatonPanel.Visible = false;
            Tanggal.Text = DateTime.Now.ToShortDateString();
        }

        protected void Tambah_Clicked(object sender, EventArgs e)
        {
            BalitasServiceClient proxyBalita = new BalitasServiceClient();
            int idBalita = proxyBalita.GetIdByName(Balita.Text);
            proxyBalita.Close();

            PosyandusServiceClient proxyPosyandu = new PosyandusServiceClient();
            int idPosyandu = proxyPosyandu.GetIdByName(Posyandu.Text);
            proxyPosyandu.Close();

            KegiatansServiceClient proxyKegiatan = new KegiatansServiceClient();
            proxyKegiatan.InsertKegiatan(idBalita, idPosyandu, Convert.ToDateTime(Tanggal.Text), Convert.ToDouble(Berat.Text),
                Convert.ToDouble(Tinggi.Text));
            proxyKegiatan.Close();

            successNotificatonPanel.Visible = true;
        }
    }
}