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
    public class ImunisasisServiceImpl : IImunisasisService
    {
        public void InsertImunisasi(DateTime hbo, DateTime bcg_Polio1, DateTime dptHb1_Polio2, DateTime dptHb2_Polio2,
                DateTime dptHb3_Polio4, DateTime campak)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Imunisasi imun = new Imunisasi();

                imun.hbo = hbo;
                imun.bcg_Polio1 = bcg_Polio1;
                imun.dptHb1_Polio2 = dptHb1_Polio2;
                imun.dptHb2_Polio2 = dptHb2_Polio2;
                imun.dptHb3_Polio4 = dptHb3_Polio4;
                imun.campak = campak;

                dc.Imunisasis.AddObject(imun);
                dc.SaveChanges();
            }
        }

        public ImunisasiData GetImunisasiById(int idImunisasi)
        {
            ImunisasiData imunisasiData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Imunisasi matching = db.Imunisasis.First(
                        p => p.idImunisasi == idImunisasi);

                    imunisasiData = new ImunisasiData()
                    {
                        idImunisasi = Convert.ToInt32(matching.idImunisasi),
                        hbo = Convert.ToDateTime(matching.hbo),
                        bcg_Polio1 = Convert.ToDateTime(matching.bcg_Polio1),
                        dptHb1_Polio2 = Convert.ToDateTime(matching.dptHb1_Polio2),
                        dptHb2_Polio2 = Convert.ToDateTime(matching.dptHb2_Polio2),
                        dptHb3_Polio4 = Convert.ToDateTime(matching.dptHb3_Polio4),
                        campak = Convert.ToDateTime(matching.campak)
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return imunisasiData;
        }

        public void UpdateImunisasi(int id, DateTime hbo, DateTime bcg_Polio1, DateTime dptHb1_Polio2, DateTime dptHb2_Polio2,
                DateTime dptHb3_Polio4, DateTime campak)
        {
            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Imunisasi imun = db.Imunisasis.Single(p => p.idImunisasi == id);

                    imun.hbo = hbo;
                    imun.bcg_Polio1 = bcg_Polio1;
                    imun.dptHb1_Polio2 = dptHb1_Polio2;
                    imun.dptHb2_Polio2 = dptHb2_Polio2;
                    imun.dptHb3_Polio4 = dptHb3_Polio4;
                    imun.campak = campak;

                    db.SaveChanges();
                }
            }
            catch
            {
                // Ignore exceptions
            }
        }
    }
}