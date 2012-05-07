using System.Collections.Generic; 
using System.Text; 
using System; 

namespace Bhm.Presentation
{
    public class Ayah
    {
        public Ayah()
        {
			Balitas = new List<Balita>();
        }

        public virtual int idAyah { get; set; }
        public virtual IList<Balita> Balitas { get; set; }
        public virtual string namaAyah { get; set; }
        public virtual string pkjAyah { get; set; }
        public virtual System.Nullable<System.DateTime> tlAyah { get; set; }
        public virtual string alamatAyah { get; set; }
    }
}
