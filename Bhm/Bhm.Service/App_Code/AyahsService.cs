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

        public AyahData GetAyahById(int id)
        {
            AyahData ayahData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Ayah matchingAyah = db.Ayahs.First(p => p.idAyah == id);

                    ayahData = new AyahData()
                    {
                        namaAyah = matchingAyah.namaAyah,
                        pkjAyah = matchingAyah.pkjAyah,
                        tlAyah = Convert.ToDateTime(matchingAyah.tlAyah),
                        alamatAyah = matchingAyah.alamatAyah
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return ayahData;
        }

        public int GetIdByName(string nama)
        {
            int idAyah = 0;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Ayah matchingAyah = db.Ayahs.First(
                        p => String.Compare(p.namaAyah, nama) == 0);

                    idAyah = matchingAyah.idAyah;
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return idAyah;
        }
    }
}