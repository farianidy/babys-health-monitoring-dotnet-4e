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

        // Tambah balita
        [OperationContract]
        void InsertBalita(int idAyah, int idIbu, string nama, DateTime tl, string alamat, int anak, string jk,
            double bbl, double tbl);

        // Update balita
        [OperationContract]
        void UpdateBalita(int id, int idAyah, int idIbu, int idVit, int idImun, string nama, DateTime tl, string alamat, int anak, string jk,
            double bbl, double tbl);

        [OperationContract]
        BalitaData GetBalita(string namaBalita, string namaAyah, string namaIbu);

        [OperationContract]
        int GetIdByName(string nama);

        [OperationContract]
        BalitaData GetBalitaByName(string nama);
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
        public double bbl { get; set; }

        [DataMember]
        public double tbl { get; set; }
    }
}