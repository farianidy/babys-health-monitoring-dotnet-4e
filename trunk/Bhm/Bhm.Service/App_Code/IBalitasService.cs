using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Balitas
{
    [ServiceContract]
    public interface IBalitasService
    {
        // Ambil daftar nama balita
        [OperationContract]
        List<string> ListBalita();

        // Ambil detail 1 balita dari nama
        [OperationContract]
        BalitaData GetBalita(string nama);

        // Tambah balita
        [OperationContract]
        bool insertBalita();
    }

    [DataContract]
    public class BalitaData
    {
        [DataMember]
        public int idBalita { get; set; }

        [DataMember]
        public int idAyah { get; set; }

        [DataMember]
        public int idIbu { get; set; }

        [DataMember]
        public int idVitamin { get; set; }

        [DataMember]
        public int idImunisasi { get; set; }

        [DataMember]
        public string namaBalita { get; set; }

        [DataMember]
        public DateTime tlBalita { get; set; }

        [DataMember]
        public string alamatBalita { get; set; }

        [DataMember]
        public int anakKe { get; set; }

        [DataMember]
        public string jnsKelamin { get; set; }

        [DataMember]
        public float bbl { get; set; }

        [DataMember]
        public float tbl { get; set; }
    }
}