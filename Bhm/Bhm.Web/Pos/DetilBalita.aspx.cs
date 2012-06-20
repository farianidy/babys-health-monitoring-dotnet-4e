using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhm.Web.Pos
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
        }
    }
}