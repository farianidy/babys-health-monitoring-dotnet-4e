using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Bhm.Model;

namespace Pegawais
{
    public class PegawaisServiceImpl : IPegawaisService
    {
        public List<string> ListPegawai()
        {
            List<string> pegawaiList = new List<string>();

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    var pegawais = from Pegawai in db.Pegawais
                                   select Pegawai.namaPgw;

                    pegawaiList = pegawais.ToList();
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return pegawaiList;
        }

        public PegawaiData GetPegawai(string nama)
        {
            PegawaiData pegawaiData = null;

            try
            {
                using (DbBhmEntities db = new DbBhmEntities())
                {
                    Pegawai matchingPegawai = db.Pegawais.First(
                        p => String.Compare(p.namaPgw, nama) == 0);

                    pegawaiData = new PegawaiData()
                    {
                        idPgw = matchingPegawai.idPgw,
                        namaPgw = matchingPegawai.namaPgw,
                        instansi = matchingPegawai.instansi,
                        usernamePgw = matchingPegawai.usernamePgw,
                        passwordPgw = matchingPegawai.passwordPgw
                    };
                }
            }
            catch
            {
                // Ignore exceptions
            }

            return pegawaiData;
        }
    }
}