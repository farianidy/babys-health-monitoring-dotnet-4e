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

         public IbuData GetBalita (int id)
         {
             IbuData ibuData = null;

             try
             {
                 using (DbBhmEntities db = new DbBhmEntities())
                 {
                     Ibu matchingIbu = db.Ibus.First(p => int.Equals(p.idIbu, id));

                     ibuData = new IbuData()
                     {
                         idIbu = matchingIbu.idIbu,
                         namaIbu = matchingIbu.namaIbu,
                         pkjIbu = matchingIbu.pkjIbu,
                         //tlIbu = matchingIbu.tlIbu,
                         alamatIbu = matchingIbu.alamatIbu,
                     };
                }
             }
             catch
             {
                 // Ignore exceptions
             }

             return ibuData;
         }

       
    }
}