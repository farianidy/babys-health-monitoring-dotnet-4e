using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Model {
    
    
    public class AyahMap : ClassMap<Ayah> {
        
        public AyahMap() {
			Table("Ayah");
			LazyLoad();
			Id(x => x.idAyah).GeneratedBy.Identity().Column("idAyah");
			Map(x => x.namaAyah).Column("namaAyah").Length(30);
			Map(x => x.pkjAyah).Column("pkjAyah").Length(30);
			Map(x => x.tlAyah).Column("tlAyah");
			Map(x => x.alamatAyah).Column("alamatAyah").Length(100);
			HasMany(x => x.Balitas).KeyColumn("idAyah");
        }
    }
}
