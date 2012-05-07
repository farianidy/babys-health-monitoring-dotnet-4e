using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Presentation
{
    public class PegawaiMap : ClassMap<Pegawai>
    {
        public PegawaiMap()
        {
			Table("Pegawai");
			LazyLoad();
			Id(x => x.idPgw).GeneratedBy.Identity().Column("idPgw");
			Map(x => x.namaPgw).Column("namaPgw").Length(30);
			Map(x => x.instansi).Column("instansi").Length(30);
			Map(x => x.usernamePgw).Column("usernamePgw").Length(15);
			Map(x => x.passwordPgw).Column("passwordPgw").Length(32);
        }
    }
}
