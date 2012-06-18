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

        public BalitaData GetBalita(string nama)
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
                        //idVitamin = matchingBalita.idVitamin,
                        //idImunisasi = matchingBalita.idImunisasi,
                        //namaBalita = matchingBalita.namaBalita,
                        //tlBalita = matchingBalita.tlBalita,
                        //alamatBalita= matchingBalita.alamatBalita,
                        //anakKe = matchingBalita.anakKe,
                        //jnsKelamin = matchingBalita.jnsKelamin,
                        //bbl = matchingBalita.bbl,
                        //tbl = matchingBalita.tbl,
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return balitaData;
        }

        public bool insertBalita()
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Balita bal = new Balita();

                bal.idBalita = 123;
                bal.idAyah = 456;
                bal.idIbu = 789;
                bal.idVitamin = 111;
                bal.idImunisasi = 222;
                bal.namaBalita = "Fitri";
                bal.tlBalita = DateTime.Now;
                bal.alamatBalita = "Bontang";
                bal.anakKe = 1;
                bal.jnsKelamin = "P";
                bal.bbl = 3;
                bal.tbl = 50;

                dc.Balitas.AddObject(bal);
                dc.SaveChanges();
            }

            return true;
        }

    }
}