using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Posyandus
{
    public class PosyandusServiceImpl : IPosyandusService
    {
        public List<string> ListPosyandu()
        {
            List<string> posyanduList = new List<string>();

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    var posyandus = from Posyandu in db.Posyandus
                                    select Posyandu.namaPosyandu;

                    posyanduList = posyandus.ToList();
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return posyanduList;
        }

        public PosyanduData GetPosyandu(string nama)
        {
            PosyanduData posyanduData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Posyandu matchingPosyandu = db.Posyandus.First(
                        p => String.Compare(p.namaPosyandu, nama) == 0);

                    posyanduData = new PosyanduData()
                    {
                        idPosyandu = matchingPosyandu.idPosyandu,
                        namaPosyandu = matchingPosyandu.namaPosyandu,
                        desaPosyandu = matchingPosyandu.desaPosyandu,
                        kecPosyandu = matchingPosyandu.kecPosyandu,
                        kabPosyandu = matchingPosyandu.kabPosyandu,
                        provPosyandu = matchingPosyandu.provPosyandu
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return posyanduData;
        }

        public PosyanduData[] GetAllPosyandu()
        {
            PosyanduData[] allPosyandu = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    IQueryable<Posyandu> results = from p in db.Posyandus
                                                   select p;

                    int counter = results.Count<Posyandu>();
                    allPosyandu = new PosyanduData[counter];

                    int i = 0;
                    foreach (Posyandu posyandu in results)
                    {
                        allPosyandu[i] = new PosyanduData();
                        allPosyandu[i].idPosyandu = posyandu.idPosyandu;
                        allPosyandu[i].namaPosyandu = posyandu.namaPosyandu;
                        allPosyandu[i].desaPosyandu = posyandu.desaPosyandu;
                        allPosyandu[i].kecPosyandu = posyandu.kecPosyandu;
                        allPosyandu[i].kabPosyandu = posyandu.kabPosyandu;
                        allPosyandu[i++].provPosyandu = posyandu.provPosyandu;
                    }
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return allPosyandu;
        }

        public List<string> ListKecamatan()
        {
            List<string> kecamatanList = new List<string>();

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    var kecamatans = (from Posyandu in db.Posyandus
                                     select Posyandu.kecPosyandu).Distinct();

                    kecamatanList = kecamatans.ToList();
                    
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return kecamatanList;
        }

        public void InsertPosyandu(string nama, string desa, string kec, string kab, string prov)
        {
            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Posyandu posyandu = new Posyandu();

                    posyandu.namaPosyandu = nama;
                    posyandu.desaPosyandu = desa;
                    posyandu.kecPosyandu = kec;
                    posyandu.kabPosyandu = kab;
                    posyandu.provPosyandu = prov;

                    db.Posyandus.AddObject(posyandu);
                    db.SaveChanges();
                }
            }
            catch
            {
                // Ignore exceptions
            }
        }

        public void UpdatePosyandu(int id, string nama, string desa, string kec, string kab, string prov)
        {
            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Posyandu posyandu = db.Posyandus.Single(p => p.idPosyandu == id);

                    posyandu.namaPosyandu = nama;
                    posyandu.desaPosyandu = desa;
                    posyandu.kecPosyandu = kec;
                    posyandu.kabPosyandu = kab;
                    posyandu.provPosyandu = prov;

                    db.SaveChanges();
                }
            }
            catch
            {
                // Ignore exceptions
            }
        }

        public int GetIdByName(string nama)
        {
            int idPosyandu = 0;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Posyandu matching = db.Posyandus.First(
                        p => String.Compare(p.namaPosyandu, nama) == 0);

                    idPosyandu = matching.idPosyandu;
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return idPosyandu;
        }
    }
}