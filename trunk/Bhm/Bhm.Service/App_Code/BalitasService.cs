using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

using Bhm.Model;

namespace Balitas
{
    public class BalitasServiceImpl : IBalitasService
    {
        public List<string> ListBalita()
        {
            List<string> balitaList = new List<string>();

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    var balitas = from Balita in db.Balitas
                                  select Balita.namaBalita;

                    balitaList = balitas.ToList();
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return balitaList;
        }

        public void InsertBalita(int idAyah, int idIbu, string nama, DateTime tl, string alamat, int anak,
            string jk, double bbl, double tbl)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Balita balita = new Balita();

                balita.idAyah = idAyah;
                balita.idIbu = idIbu;
                balita.idVitamin = null;
                balita.idImunisasi = null;
                balita.namaBalita = nama;
                balita.tlBalita = tl;
                balita.alamatBalita = alamat;
                balita.anakKe = anak;
                balita.jnsKelamin = jk;
                balita.bbl = bbl;
                balita.tbl = tbl;

                dc.Balitas.AddObject(balita);
                dc.SaveChanges();
            }
        }

        public void UpdateBalita(int id, int idAyah, int idIbu, int idVit, int idImun, string nama, DateTime tl, string alamat, int anak,
            string jk, double bbl, double tbl)
        {
            using (DbBhmEntities db = new DbBhmEntities())
            {
                Balita balita = db.Balitas.Single(p => p.idBalita == id);

                balita.idAyah = idAyah;
                balita.idIbu = idIbu;
                balita.idVitamin = idVit;
                balita.idImunisasi = idImun;
                balita.namaBalita = nama;
                balita.tlBalita = tl;
                balita.alamatBalita = alamat;
                balita.anakKe = anak;
                balita.jnsKelamin = jk;
                balita.bbl = bbl;
                balita.tbl = tbl;

                db.SaveChanges();
            }
        }

        public BalitaData GetBalita(string namaBalita, string namaAyah, string namaIbu)
        {
            BalitaData balitaData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Balita matchingBalita = db.Balitas.First(
                        p => String.Compare(p.namaBalita, namaBalita) == 0);
                    Ayah matchingAyah = db.Ayahs.First(
                        p => String.Compare(p.namaAyah, namaAyah) == 0);
                    Ibu matchingIbu = db.Ibus.First(
                        p => String.Compare(p.namaIbu, namaIbu) == 0);


                    balitaData = new BalitaData()
                    {
                        idBalita = matchingBalita.idBalita,
                        idAyah = matchingBalita.idAyah,
                        idIbu = matchingBalita.idIbu,
                        namaBalita = matchingBalita.namaBalita,
                        tlBalita = Convert.ToDateTime(matchingBalita.tlBalita),
                        alamatBalita = matchingBalita.alamatBalita,
                        anakKe = Convert.ToInt32(matchingBalita.anakKe),
                        jnsKelamin = matchingBalita.jnsKelamin,
                        bbl = Convert.ToDouble(matchingBalita.bbl),
                        tbl = Convert.ToDouble(matchingBalita.tbl)
                    };
                }
            }
<<<<<<< .mine
            catch
            {
                // Ignore exceptions
            }

=======
>>>>>>> .r12
            return balitaData;
        }

        public int GetIdByName(string nama)
        {
            int idBalita = 0;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Balita matching = db.Balitas.First(
                        p => String.Compare(p.namaBalita, nama) == 0);

                    idBalita = matching.idBalita;
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return idBalita;
        }

        public BalitaData GetBalitaByName(string nama)
        {
            BalitaData balitaData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Balita matchingBalita = db.Balitas.First(
                        p => String.Compare(p.namaBalita, nama) == 0);

                    balitaData = new BalitaData()
                    {
                        idBalita = matchingBalita.idBalita,
                        idAyah = matchingBalita.idAyah,
                        idIbu = matchingBalita.idIbu,
                        idImunisasi = Convert.ToInt32(matchingBalita.idImunisasi),
                        idVitamin = Convert.ToInt32(matchingBalita.idVitamin),
                        namaBalita = matchingBalita.namaBalita,
                        tlBalita = Convert.ToDateTime(matchingBalita.tlBalita),
                        alamatBalita = matchingBalita.alamatBalita,
                        anakKe = Convert.ToInt32(matchingBalita.anakKe),
                        jnsKelamin = matchingBalita.jnsKelamin,
                        bbl = Convert.ToDouble(matchingBalita.bbl),
                        tbl = Convert.ToDouble(matchingBalita.tbl)
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return balitaData;
        }

        public int GetIdByName(string nama)
        {
            int idBalita = 0;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Balita matching = db.Balitas.First(
                        p => String.Compare(p.namaBalita, nama) == 0);

                    idBalita = matching.idBalita;
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return idBalita;
        }
    }
}