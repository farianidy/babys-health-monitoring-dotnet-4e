using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Kegiatan
    {
        public Kegiatan()
        {
			Urutans = new List<Urutan>();
        }

        public virtual int idKeg { get; set; }
        public virtual IList<Urutan> Urutans { get; set; }
        public virtual System.Nullable<int> idPosyandu { get; set; }
        public virtual System.Nullable<System.DateTime> tglPeriksa { get; set; }
        public virtual System.Nullable<double> bb { get; set; }
        public virtual System.Nullable<double> tb { get; set; }
    }
}
