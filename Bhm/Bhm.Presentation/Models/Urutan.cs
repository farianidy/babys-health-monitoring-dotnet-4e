using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Urutan
    {
        //public Urutan()
        //{
        //}

        public virtual int idKeg { get; set; }
        public virtual int idBalita { get; set; }
        public virtual int idUrutan { get; set; }
        public virtual Kegiatan Kegiatan { get; set; }
        public virtual Balita Balita { get; set; }
    }
}
