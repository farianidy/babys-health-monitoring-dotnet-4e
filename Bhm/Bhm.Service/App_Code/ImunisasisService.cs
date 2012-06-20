using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Imunisasis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ImunisasisService" in code, svc and config file together.
    public class ImunisasisService : IImunisasisService
    {
        public void InsertImunisasi(DateTime hbo, DateTime bcg_Polio1, DateTime dptHb1_Polio2, DateTime dptHb2_Polio2,
                DateTime dptHb3_Polio4, DateTime campak)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Imunisasi imunisasi = new Imunisasi();

                imunisasi.hbo = DateTime.Now;
                imunisasi.bcg_Polio1 = DateTime.Now;
                imunisasi.dptHb1_Polio2 = DateTime.Now;
                imunisasi.dptHb2_Polio2 = DateTime.Now;
                imunisasi.dptHb3_Polio4 = DateTime.Now;
                imunisasi.campak = DateTime.Now;

                dc.Imunisasis.AddObject(imunisasi);
                dc.SaveChanges();
            }
        }
    }
}