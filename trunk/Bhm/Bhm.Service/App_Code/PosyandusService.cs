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
    }
}