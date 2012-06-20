using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Kegiatans
{
    public class KegiatansServiceImpl : IKegiatansService
    {
        public void InsertKegiatan(int idBalita, int idPosyandu, DateTime tgl, double bb, double tb)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Kegiatan kegiatan = new Kegiatan();

                kegiatan.idBalita = idBalita;
                kegiatan.idPosyandu = idPosyandu;
                kegiatan.tglPeriksa = tgl;
                kegiatan.bb = bb;
                kegiatan.tb = tb;

                dc.Kegiatans.AddObject(kegiatan);
                dc.SaveChanges();
            }
        }
    }
}