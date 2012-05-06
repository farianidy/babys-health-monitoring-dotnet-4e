using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Bhm.Model {
    
    public class Posyandu {
        public Posyandu() { }
        public virtual int idPosyandu { get; set; }
        public virtual Kegiatan Kegiatan { get; set; }
        public virtual string namaPosyandu { get; set; }
        public virtual string desaPosyandu { get; set; }
        public virtual string kecPosyandu { get; set; }
        public virtual string kabPosyandu { get; set; }
        public virtual string provPosyandu { get; set; }
    }
}
