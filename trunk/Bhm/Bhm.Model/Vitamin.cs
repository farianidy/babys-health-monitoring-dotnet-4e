using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Bhm.Model {
    
    public class Vitamin {
        public Vitamin() {
			Balitas = new List<Balita>();
        }
        public virtual int idVitamin { get; set; }
        public virtual IList<Balita> Balitas { get; set; }
        public virtual System.Nullable<System.DateTime> kapsulBiru { get; set; }
        public virtual System.Nullable<System.DateTime> kapsulMerah1 { get; set; }
        public virtual System.Nullable<System.DateTime> kapsulMerah2 { get; set; }
        public virtual System.Nullable<System.DateTime> kapsulMerah3 { get; set; }
        public virtual System.Nullable<System.DateTime> kapsulMerah4 { get; set; }
    }
}
