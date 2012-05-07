using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Mapping;

namespace Bhm.Presentation
{
    public class PosyanduMap : ClassMap<Posyandu>
    {
        public PosyanduMap()
        {
            //Table("Posyandu");
            //LazyLoad();
            //Id(x => x.idPosyandu).GeneratedBy.Identity().Column("idPosyandu");
            //References(x => x.Pos).Column("idPosyandu");
            //Map(x => x.namaPosyandu).Column("namaPosyandu").Length(30);
            //Map(x => x.desaPosyandu).Column("desaPosyandu").Length(30);
            //Map(x => x.kecPosyandu).Column("kecPosyandu").Length(30);
            //Map(x => x.kabPosyandu).Column("kabPosyandu").Length(30);
            //Map(x => x.provPosyandu).Column("provPosyandu").Length(30);
            //HasMany(x => x.Posyandus).KeyColumn("idPosyandu");

            Id(x => x.idPosyandu);
            Map(x => x.namaPosyandu);
            Map(x => x.desaPosyandu);
            Map(x => x.kecPosyandu);
            Map(x => x.kabPosyandu);
            Map(x => x.provPosyandu);
        }
    }
}
