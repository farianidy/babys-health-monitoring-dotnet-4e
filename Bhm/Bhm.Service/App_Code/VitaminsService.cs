using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Bhm.Model;

namespace Vitamins
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VitaminsService" in code, svc and config file together.
    public class VitaminsServiceImpl : IVitaminsService
    {
        public void InsertVitamin(DateTime kapsulBiru, DateTime kapsulMerah1, DateTime kapsulMerah2, DateTime kapsulMerah3,
            DateTime kapsulMerah4)
        {
            using (DbBhmEntities dc = new DbBhmEntities())
            {
                Vitamin vitamin = new Vitamin();

                vitamin.kapsulBiru = DateTime.Now;
                vitamin.kapsulMerah1 = DateTime.Now;
                vitamin.kapsulMerah2 = DateTime.Now;
                vitamin.kapsulMerah3 = DateTime.Now;
                vitamin.kapsulMerah4 = DateTime.Now;

                dc.Vitamins.AddObject(vitamin);
                dc.SaveChanges();
            }
        }
    }
}
