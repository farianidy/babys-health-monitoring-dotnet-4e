using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kegiatans
{
    [ServiceContract]
    public interface IKegiatansService
    {
        // Tambah kegiatan
        [OperationContract]
        void InsertKegiatan(int idBalita, int idPosyandu, DateTime tgl, double bb, double tb);
    }

    [DataContract]
    public class KegiatanData
    {
        [DataMember]
        public int idKeg { get; set; }

        [DataMember]
        public int idPosyandu { get; set; }

        [DataMember]
        public int idBalita { get; set; }

        [DataMember]
        public DateTime tglPeriksa { get; set; }

        [DataMember]
        public double bb { get; set; }

        [DataMember]
        public double tb { get; set; }
    }
}