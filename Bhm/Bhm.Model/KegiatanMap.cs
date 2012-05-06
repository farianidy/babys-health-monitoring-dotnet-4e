using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Model {
    
    
    public class KegiatanMap : ClassMap<Kegiatan> {
        
        public KegiatanMap() {
			Table("Kegiatan");
			LazyLoad();
			Id(x => x.idKeg).GeneratedBy.Identity().Column("idKeg");
			Map(x => x.tglPeriksa).Column("tglPeriksa");
			Map(x => x.bb).Column("bb");
			Map(x => x.tb).Column("tb");
			HasMany(x => x.Posyandus).KeyColumn("idKeg");
			HasMany(x => x.Urutans).KeyColumn("idKeg");
        }
    }
}
