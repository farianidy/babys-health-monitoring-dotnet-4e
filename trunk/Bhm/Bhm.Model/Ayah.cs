using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Bhm.Model {
    
    public class Ayah {
        public Ayah() {
			Balitas = new List<Balitum>();
        }
        public virtual int idAyah { get; set; }
        public virtual IList<Balitum> Balitas { get; set; }
        public virtual string namaAyah { get; set; }
        public virtual string pkjAyah { get; set; }
        public virtual System.Nullable<System.DateTime> tlAyah { get; set; }
        public virtual string alamatAyah { get; set; }
    }
}
