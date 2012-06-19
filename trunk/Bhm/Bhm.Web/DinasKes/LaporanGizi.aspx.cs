using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bhm.Web.PosyandusService;

namespace Bhm.Web.DinasKes
{
    public partial class LaporanGizi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PosyandusServiceClient proxyPosyandu = new PosyandusServiceClient();
            KecamatanDropDown.DataSource = proxyPosyandu.ListKecamatan();
            KecamatanDropDown.DataBind();
        }
    }
}