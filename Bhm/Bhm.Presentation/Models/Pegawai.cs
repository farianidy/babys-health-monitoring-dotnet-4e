using System.Collections.Generic; 
using System.Text; 
using System;

namespace Bhm.Presentation
{
    public class Pegawai
    {
        public Pegawai()
        {
        }

        public virtual int idPgw { get; set; }
        public virtual string namaPgw { get; set; }
        public virtual string instansi { get; set; }
        public virtual string usernamePgw { get; set; }
        public virtual string passwordPgw { get; set; }
    }
}
