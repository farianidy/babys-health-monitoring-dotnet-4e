using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Vitamins
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVitaminsService" in both code and config file together.
    [ServiceContract]
    public interface IVitaminsService
    {
        // Tambah vitamin
        [OperationContract]
        void InsertVitamin(DateTime kapsulBiru, DateTime kapsulMerah1, DateTime kapsulMerah2, DateTime kapsulMerah3,
        DateTime kapsulMerah4);
    }

    [DataContract]
    public class VitaminData
    {
        [DataMember]
        public int idVitamin { get; set; }

        [DataMember]
        public DateTime kapsulBiru { get; set; }

        [DataMember]
        public DateTime kapsulMerah1 { get; set; }

        [DataMember]
        public DateTime kapsulMerah2 { get; set; }

        [DataMember]
        public DateTime kapsulMerah3 { get; set; }

        [DataMember]
        public DateTime kapsulMerah4 { get; set; }
    }
}