using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Bhm.Presentation
{
    public class IbuMap : ClassMap<Ibu>
    {
        public IbuMap()
        {
			Table("Ibu");
			LazyLoad();
			Id(x => x.idIbu).GeneratedBy.Identity().Column("idIbu");
			Map(x => x.namaIbu).Column("namaIbu").Length(30);
			Map(x => x.pkjIbu).Column("pkjIbu").Length(30);
			Map(x => x.tlIbu).Column("tlIbu");
			Map(x => x.alamatIbu).Column("alamatIbu").Length(100);
			HasMany(x => x.Balitas).KeyColumn("idIbu");
        }
    }
}
