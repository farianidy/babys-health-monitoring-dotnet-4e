using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Bhm.Model {
    
    public class Ibu {
        public Ibu() {
			Balitas = new List<Balita>();
        }
        public virtual int idIbu { get; set; }
        public virtual IList<Balita> Balitas { get; set; }
        public virtual string namaIbu { get; set; }
        public virtual string pkjIbu { get; set; }
        public virtual System.Nullable<System.DateTime> tlIbu { get; set; }
        public virtual string alamatIbu { get; set; }
    }
}
