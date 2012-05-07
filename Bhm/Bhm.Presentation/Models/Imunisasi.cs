using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Imunisasi
    {
        public Imunisasi()
        {
			Balitas = new List<Balita>();
        }

        public virtual int idImunisasi { get; set; }
        public virtual IList<Balita> Balitas { get; set; }
        public virtual System.Nullable<System.DateTime> hbo { get; set; }
        public virtual System.Nullable<System.DateTime> bcg_Polio1 { get; set; }
        public virtual System.Nullable<System.DateTime> dptHb1_Polio2 { get; set; }
        public virtual System.Nullable<System.DateTime> dptHb2_Polio2 { get; set; }
        public virtual System.Nullable<System.DateTime> dptHb3_Polio4 { get; set; }
        public virtual System.Nullable<System.DateTime> campak { get; set; }
    }
}
