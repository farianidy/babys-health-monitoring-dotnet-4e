using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Mapping;

namespace Bhm.Presentation
{
    public class UrutanMap : ClassMap<Urutan>
    {
        public UrutanMap()
        {
			Table("Urutan");
			LazyLoad();
			//CompositeId().KeyProperty(x => x.idKeg, "idKeg").KeyProperty(x => x.idBalita, "idBalita").KeyProperty(x => x.idUrutan, "idUrutan");
            Id(x => x.idUrutan).GeneratedBy.Identity().Column("idUrutan");
			References(x => x.Kegiatan).Column("idKeg");
			References(x => x.Balita).Column("idBalita");
        }
    }
}
