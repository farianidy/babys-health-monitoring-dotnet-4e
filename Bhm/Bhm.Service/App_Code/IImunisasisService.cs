using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Imunisasis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IImunisasisService" in both code and config file together.
    [ServiceContract]
    public interface IImunisasisService
    {
        [OperationContract]
        //Tambah Imunisasi
        void InsertImunisasi(DateTime hbo, DateTime bcg_Polio1, DateTime dptHb1_Polio2, DateTime dptHb2_Polio2,
                    DateTime dptHb3_Polio4, DateTime campak);

        [OperationContract]
        ImunisasiData GetImunisasiById(int idImunisasi);

        [OperationContract]
        void UpdateImunisasi(int id, DateTime hbo, DateTime bcg_Polio1, DateTime dptHb1_Polio2, DateTime dptHb2_Polio2,
                DateTime dptHb3_Polio4, DateTime campak);
    }

    [DataContract]
    public class ImunisasiData
    {
        [DataMember]
        public int idImunisasi { get; set; }

        [DataMember]
        public DateTime hbo { get; set; }

        [DataMember]
        public DateTime bcg_Polio1 { get; set; }

        [DataMember]
        public DateTime dptHb1_Polio2 { get; set; }

        [DataMember]
        public DateTime dptHb2_Polio2 { get; set; }

        [DataMember]
        public DateTime dptHb3_Polio4 { get; set; }

        [DataMember]
        public DateTime campak { get; set; }
    }
}
