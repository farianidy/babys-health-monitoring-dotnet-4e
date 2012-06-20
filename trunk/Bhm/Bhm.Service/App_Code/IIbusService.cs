using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ibus
{
    [ServiceContract]
    public interface IIbusService
    {
        // Tambah ibu
        [OperationContract]
        void InsertIbu(string nama, string pkj, DateTime tl, string alamat);

        [OperationContract]
        IbuData GetIbuById(int id);

        [OperationContract]
        int GetIdByName(string nama);
    }

    [DataContract]
    public class IbuData
    {
        [DataMember]
        public int idIbu { get; set; }

        [DataMember]
        public string namaIbu { get; set; }

        [DataMember]
        public string pkjIbu { get; set; }

        [DataMember]
        public DateTime tlIbu { get; set; }

        [DataMember]
        public string alamatIbu { get; set; }
    }
}