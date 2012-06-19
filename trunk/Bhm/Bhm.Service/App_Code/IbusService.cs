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
    }
}