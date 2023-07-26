using Autofac;
using DevExpress.Utils.Design;
using DevExpress.Xpo.Logger.Transport;
using DevExpress.XtraWaitForm;
using EloshStore.BLL.Abstract;
using EloshStore.BLL.Concrete;
using EloshStore.Dal.Abstract;
using EloshStore.Dal.Concrete.Context;
using EloshStore.Dal.Concrete.EntityFramework;
using EloshStore.UIü;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EloshStoree.UI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the Autofac container builder
            var builder = new ContainerBuilder();

            // Register your dependencies here
            builder.RegisterType<ProductPurchaseDal>().As<IProductPurchaseDal>();
            builder.RegisterType<ProductPurchaseManager>().As<IProductPurchaseService>();

            builder.RegisterType<ProductSaleDal>().As<IProductSaleDal>();
            builder.RegisterType<ProductSaleManager>().As<IProductSaleService>();

            builder.RegisterType<StockDal>().As<IStockDal>();
            builder.RegisterType<StockManager>().As<IStockService>();

            builder.RegisterType<DashboardForm>().AsSelf();
            builder.RegisterType<ProductFrom>().AsSelf();
            builder.RegisterType<ProductSellForm>().AsSelf();
            builder.RegisterType<StockForm>().AsSelf(); 

            // Build the container
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<ProductFrom>();
                Application.Run(mainForm);
            }
        }

    }
}