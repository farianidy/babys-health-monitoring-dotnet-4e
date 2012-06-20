using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Ibus
{
    public class IbusServiceImpl : IIbusService
    {
        public void InsertIbu(string nama, string pkj, DateTime tl, string alamat)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Ibu ibu = new Ibu();

                ibu.namaIbu = nama;
                ibu.pkjIbu = pkj;
                ibu.tlIbu = tl;
                ibu.alamatIbu = alamat;

                dc.Ibus.AddObject(ibu);
                dc.SaveChanges();
            }
        }

        public IbuData GetIbuById(int id)
        {
            IbuData ibuData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Ibu matching = db.Ibus.First(p => p.idIbu == id);

                    ibuData = new IbuData()
                    {
                        namaIbu = matching.namaIbu,
                        pkjIbu = matching.pkjIbu,
                        tlIbu = Convert.ToDateTime(matching.tlIbu),
                        alamatIbu = matching.alamatIbu
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return ibuData;
        }

        public int GetIdByName(string nama)
        {
            int idIbu = 0;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Ibu matchingIbu = db.Ibus.First(
                        p => String.Compare(p.namaIbu, nama) == 0);

                    idIbu = matchingIbu.idIbu;
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return idIbu;
        }
    }
}