using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Model {
    
    
    public class ImunisasiMap : ClassMap<Imunisasi> {
        
        public ImunisasiMap() {
			Table("Imunisasi");
			LazyLoad();
			Id(x => x.idImunisasi).GeneratedBy.Identity().Column("idImunisasi");
			Map(x => x.hbo).Column("hbo");
			Map(x => x.bcg_Polio1).Column("bcg_Polio1");
			Map(x => x.dptHb1_Polio2).Column("dptHb1_Polio2");
			Map(x => x.dptHb2_Polio2).Column("dptHb2_Polio2");
			Map(x => x.dptHb3_Polio4).Column("dptHb3_Polio4");
			Map(x => x.campak).Column("campak");
			HasMany(x => x.Balitas).KeyColumn("idImunisasi");
        }
    }
}
