using EloshStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Dal.Concrete.Context
{
    public class EloshDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=myservername;Database=yourdbname;Uid=sa;Password=yourpassword;TrustServerCertificate=True;");
        }

        public DbSet<ProductPurchase> ProductPurchases { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
    }
}
