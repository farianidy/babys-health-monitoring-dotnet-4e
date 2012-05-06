using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Model {
    
    
    public class VitaminMap : ClassMap<Vitamin> {
        
        public VitaminMap() {
			Table("Vitamin");
			LazyLoad();
			Id(x => x.idVitamin).GeneratedBy.Identity().Column("idVitamin");
			Map(x => x.kapsulBiru).Column("kapsulBiru");
			Map(x => x.kapsulMerah1).Column("kapsulMerah1");
			Map(x => x.kapsulMerah2).Column("kapsulMerah2");
			Map(x => x.kapsulMerah3).Column("kapsulMerah3");
			Map(x => x.kapsulMerah4).Column("kapsulMerah4");
			HasMany(x => x.Balitas).KeyColumn("idVitamin");
        }
    }
}
