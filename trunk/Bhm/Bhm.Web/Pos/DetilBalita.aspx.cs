using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.BalitasService;
using Bhm.Web.AyahsService;
using Bhm.Web.IbusService;


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

            BalitasServiceClient proxyBalita = new BalitasServiceClient();
            BalitaData balita = proxyBalita.GetBalita(Balita.Text, Ayah.Text, Ibu.Text);
            proxyBalita.Close();

            AyahsServiceClient proxyAyah = new AyahsServiceClient();
            AyahData ayah = proxyAyah.GetAyahById(balita.idAyah);
            proxyAyah.Close();

            IbusServiceClient proxyIbu = new IbusServiceClient();
            IbuData ibu = proxyIbu.GetIbuById(balita.idIbu);
            proxyIbu.Close();

            TglLahir.Text = balita.tlBalita.ToShortDateString();
            Alamat.Text = balita.alamatBalita;
            AnakKe.Text = Convert.ToString(balita.anakKe);
            if (Convert.ToString(balita.jnsKelamin) == "L")
                LakiRadioButton.Checked = true;
            else if (Convert.ToString(balita.jnsKelamin) == "P")
                PerempuanRadioButton.Checked = true;
            BBL.Text = Convert.ToString(balita.bbl);
            TBL.Text = Convert.ToString(balita.tbl);

            PkjAyah.Text = ayah.pkjAyah;
            TglLahirAyah.Text = ayah.tlAyah.ToShortDateString();
            AlamatAyah.Text = ayah.alamatAyah;

            PkjIbu.Text = ibu.pkjIbu;
            TglLahirIbu.Text = ibu.tlIbu.ToShortDateString();
            AlamatIbu.Text = ibu.alamatIbu;
        }
    }
}