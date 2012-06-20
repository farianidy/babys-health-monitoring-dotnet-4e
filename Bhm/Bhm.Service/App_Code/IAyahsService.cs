using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ayahs
{
    [ServiceContract]
    public interface IAyahsService
    {
        // Tambah ayah
        [OperationContract]
        void InsertAyah(string nama, string pkj, DateTime tl, string alamat);

        // Ambil detail ayah dari id
        [OperationContract]
        AyahData GetAyahById(int id);

        // Ambil id dari nama
        [OperationContract]
        int GetIdByName(string nama);

    }

    [DataContract]
    public class AyahData
    {
        [DataMember]
        public int idAyah { get; set; }

        [DataMember]
        public string namaAyah { get; set; }

        [DataMember]
        public string pkjAyah { get; set; }

        [DataMember]
        public DateTime tlAyah { get; set; }

        [DataMember]
        public string alamatAyah { get; set; }
    }
}