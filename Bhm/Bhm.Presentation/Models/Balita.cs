using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Balita
    {
        public Balita()
        {
			Urutans = new List<Urutan>();
        }

        public virtual int idBalita { get; set; }
        public virtual Ayah Ayah { get; set; }
        public virtual Ibu Ibu { get; set; }
        public virtual Vitamin Vitamin { get; set; }
        public virtual Imunisasi Imunisasi { get; set; }
        public virtual IList<Urutan> Urutans { get; set; }
        public virtual string namaBalita { get; set; }
        public virtual System.Nullable<System.DateTime> tlBalita { get; set; }
        public virtual string alamatBalita { get; set; }
        public virtual System.Nullable<int> anakKe { get; set; }
        public virtual string jnsKelamin { get; set; }
        public virtual System.Nullable<double> bbl { get; set; }
        public virtual System.Nullable<double> tbl { get; set; }
    }
}
