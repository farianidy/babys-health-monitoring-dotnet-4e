using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.BalitasService;

namespace Bhm.Web.DinasKes
{
    public partial class DetilBalita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string namaBalita = (string)Request.QueryString["Balita"];
            string namaAyah = (string)Request.QueryString["Ayah"];
            string namaIbu = (string)Request.QueryString["Ibu"];

            Balita.Text = namaBalita;
            Ayah.Text = namaAyah;
            Ibu.Text = namaIbu;

            BalitasServiceClient proxyBalita = new BalitasServiceClient();
            BalitaData user = proxyBalita.dataBalita(Balita.Text, Ayah.Text, Ibu.Text);

            proxyBalita.Close();
        }
    }
}