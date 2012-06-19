using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Pegawais
{
    [ServiceContract]
    public interface IPegawaisService
    {
        // Ambil daftar nama pegawai
        [OperationContract]
        List<string> ListPegawai();

        // Ambil detail 1 pegawai dari nama
        [OperationContract]
        PegawaiData GetPegawai(string nama);

        // Login Pegawai
        [OperationContract]
        PegawaiData CheckLogin(string username, string password);

        // Tambah Pegawai
        [OperationContract]
        void InsertPegawai(string nama, string instansi, string username, string password, bool isAdmin);
    }

    [DataContract]
    public class PegawaiData
    {
        [DataMember]
        public int idPgw { get; set; }

        [DataMember]
        public string namaPgw { get; set; }

        [DataMember]
        public string instansi { get; set; }

        [DataMember]
        public string usernamePgw { get; set; }

        [DataMember]
        public string passwordPgw { get; set; }

        [DataMember]
        public bool isAdmin { get; set; }
    }
}