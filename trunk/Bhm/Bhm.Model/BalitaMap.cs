using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Model {
    
    
    public class BalitaMap : ClassMap<Balita> {
        
        public BalitaMap() {
			Table("Balita");
			LazyLoad();
			Id(x => x.idBalita).GeneratedBy.Identity().Column("idBalita");
			References(x => x.Ayah).Column("idAyah");
			References(x => x.Ibu).Column("idIbu");
			References(x => x.Vitamin).Column("idVitamin");
			References(x => x.Imunisasi).Column("idImunisasi");
			Map(x => x.namaBalita).Column("namaBalita").Length(30);
			Map(x => x.tlBalita).Column("tlBalita");
			Map(x => x.anakKe).Column("anakKe");
			Map(x => x.jnsKelamin).Column("jnsKelamin").Length(1);
			Map(x => x.bbl).Column("bbl");
			Map(x => x.tbl).Column("tbl");
			HasMany(x => x.Urutans).KeyColumn("idBalita");
        }
    }
}
