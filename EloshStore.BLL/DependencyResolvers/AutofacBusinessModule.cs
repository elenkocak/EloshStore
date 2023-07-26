using Autofac;
using EloshStore.BLL.Abstract;
using EloshStore.BLL.Concrete;
using EloshStore.Dal.Abstract;
using EloshStore.Dal.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.DependencyResolvers
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProductPurchaseDal>().As<IProductPurchaseDal>();
            //builder.RegisterType<ProductPurchaseManager>().As<IProductPurchaseService>();

        }

    }
}
