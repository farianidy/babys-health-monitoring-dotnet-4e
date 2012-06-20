using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.AyahsService;
using Bhm.Web.IbusService;
using Bhm.Web.BalitasService;

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
            AyahsServiceClient proxyAyah = new AyahsServiceClient();
            proxyAyah.InsertAyah(Ayah.Text, PkjAyah.Text, Convert.ToDateTime(TglLahirAyah.Text), AlamatAyah.Text);
            
            IbusServiceClient proxyIbu = new IbusServiceClient();
            proxyIbu.InsertIbu(Ibu.Text, PkjIbu.Text, Convert.ToDateTime(TglLahirIbu.Text), AlamatIbu.Text);
            
            BalitasServiceClient proxyBalita = new BalitasServiceClient();
            if (LakiRadioButton.Checked == true)
            {
                proxyBalita.InsertBalita(proxyAyah.GetIdByName(Ayah.Text), proxyIbu.GetIdByName(Ibu.Text), Balita.Text, Convert.ToDateTime(TglLahirBalita.Text), AlamatBalita.Text,
                    Convert.ToInt32(AnakKe.Text), "L", Convert.ToDouble(BBL.Text), Convert.ToDouble(TBL.Text));
            }
            else if (PerempuanRadioButton.Checked == true)
            {
                proxyBalita.InsertBalita(proxyAyah.GetIdByName(Ayah.Text), proxyIbu.GetIdByName(Ibu.Text), Balita.Text, Convert.ToDateTime(TglLahirBalita.Text), AlamatBalita.Text,
                    Convert.ToInt32(AnakKe.Text), "L", Convert.ToDouble(BBL.Text), Convert.ToDouble(TBL.Text));
            }

            proxyAyah.Close();
            proxyIbu.Close();
            proxyBalita.Close();

            successNotificatonPanel.Visible = true;
        }
    }
}