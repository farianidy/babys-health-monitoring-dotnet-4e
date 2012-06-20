using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Posyandus
{
    [ServiceContract]
    public interface IPosyandusService
    {
        // Ambil daftar nama posyandu
        [OperationContract]
        List<string> ListPosyandu();

        // Ambil detail 1 posyandu dari nama
        [OperationContract]
        PosyanduData GetPosyandu(string nama);

        // Ambil detail semua data posyandu
        [OperationContract]
        PosyanduData[] GetAllPosyandu();

        // Ambil kecamatan di semua posyandu
        [OperationContract]
        List<string> ListKecamatan();

        [OperationContract]
        void InsertPosyandu(string nama, string desa, string kec, string kab, string prov);

        // Update posyandu
        [OperationContract]
        void UpdatePosyandu(int id, string nama, string desa, string kec, string kab, string prov);

        [OperationContract]
        int GetIdByName(string nama);
    }

    [DataContract]
    public class PosyanduData
    {
        [DataMember]
        public int idPosyandu { get; set; }

        [DataMember]
        public string namaPosyandu { get; set; }

        [DataMember]
        public string desaPosyandu { get; set; }

        [DataMember]
        public string kecPosyandu { get; set; }

        [DataMember]
        public string kabPosyandu { get; set; }

        [DataMember]
        public string provPosyandu { get; set; }
    }
}