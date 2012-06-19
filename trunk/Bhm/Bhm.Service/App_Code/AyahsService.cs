using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Ayahs
{
    public class AyahsServiceImpl : IAyahsService
    {
        public void InsertAyah(string nama, string pkj, DateTime tl, string alamat)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Ayah ayah = new Ayah();

                ayah.namaAyah = nama;
                ayah.pkjAyah = pkj;
                ayah.tlAyah = tl;
                ayah.alamatAyah = alamat;

                dc.Ayahs.AddObject(ayah);
                dc.SaveChanges();
            }
        }

    }
}