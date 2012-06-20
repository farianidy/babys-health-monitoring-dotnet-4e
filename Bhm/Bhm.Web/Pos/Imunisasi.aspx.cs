using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.BalitasService;
using Bhm.Web.ImunisasisService;

namespace Bhm.Web.Pos
{
    public partial class Imunisasi : System.Web.UI.Page
    {
        BalitaData balita = null;
        ImunisasiData imun = null;
        int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< .mine
            successNotificatonPanel.Visible = false;
        }

=======
            successNotificatonPanel.Visible = false;
>>>>>>> .r12
        protected void Lihat_Clicked(object sender, EventArgs e)
        {
            BalitasServiceClient proxyBalita = new BalitasServiceClient();
            balita = proxyBalita.GetBalitaByName(Name.Text);
            proxyBalita.Close();

            ImunisasisServiceClient proxyImun = new ImunisasisServiceClient();
            imun = proxyImun.GetImunisasiById(balita.idImunisasi);
            proxyImun.Close();

            if (imun.hbo != DateTime.MinValue)
            {
                HBO.Text = imun.hbo.ToShortDateString();
                HBO.Enabled = false;
                counter++;
            }
            else
                HBO.Enabled = true;

            if (imun.bcg_Polio1 != DateTime.MinValue)
            {
                BCG.Text = imun.bcg_Polio1.ToShortDateString();
                BCG.Enabled = false;
                counter++;
            }
            else
                BCG.Enabled = true;

            if (imun.dptHb1_Polio2 != DateTime.MinValue)
            {
                DPT.Text = imun.dptHb1_Polio2.ToShortDateString();
                DPT.Enabled = false;
                counter++;
            }
            else
                DPT.Enabled = true;

            if (imun.dptHb2_Polio2 != DateTime.MinValue)
            {
                DPT2.Text = imun.dptHb2_Polio2.ToShortDateString();
                DPT2.Enabled = false;
                counter++;
            }
            else
                DPT2.Enabled = true;

            if (imun.dptHb3_Polio4 != DateTime.MinValue)
            {
                DPT3.Text = imun.dptHb3_Polio4.ToShortDateString();
                DPT3.Enabled = false;
                counter++;
            }
            else
                DPT3.Enabled = true;

            if (imun.campak != DateTime.MinValue)
            {
                Campak.Text = imun.campak.ToShortDateString();
                Campak.Enabled = false;
                counter++;
            }
            else
                Campak.Enabled = true;
        }

        protected void Simpan_Clicked(object sender, EventArgs e)
        {
            ImunisasisServiceClient proxyImun = new ImunisasisServiceClient();

            if (counter == 0)
                proxyImun.InsertImunisasi(Convert.ToDateTime(HBO.Text), Convert.ToDateTime(BCG.Text),
                    Convert.ToDateTime(DPT.Text), Convert.ToDateTime(DPT2.Text), Convert.ToDateTime(DPT3.Text),
                    Convert.ToDateTime(Campak.Text));
            else
                proxyImun.UpdateImunisasi(imun.idImunisasi, Convert.ToDateTime(HBO.Text), Convert.ToDateTime(BCG.Text),
                    Convert.ToDateTime(DPT.Text), Convert.ToDateTime(DPT2.Text), Convert.ToDateTime(DPT3.Text),
                    Convert.ToDateTime(Campak.Text));

            proxyImun.Close();
            successNotificatonPanel.Visible = true;
        }
    }
}