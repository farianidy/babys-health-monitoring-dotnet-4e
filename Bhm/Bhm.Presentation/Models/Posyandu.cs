using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Posyandu
    {
        //public Posyandu()
        //{
        //    Posyandus = new List<Posyandu>();
        //}

        public virtual int idPosyandu { get; set; }
        //public virtual Posyandu Pos { get; set; }
        //public virtual IList<Posyandu> Posyandus { get; set; }
        public virtual string namaPosyandu { get; set; }
        public virtual string desaPosyandu { get; set; }
        public virtual string kecPosyandu { get; set; }
        public virtual string kabPosyandu { get; set; }
        public virtual string provPosyandu { get; set; }
    }
}
