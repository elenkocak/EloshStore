using EloshStore.Core.EntityFramework;
using EloshStore.Dal.Abstract;
using EloshStore.Dal.Concrete.Context;
using EloshStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Dal.Concrete.EntityFramework
{
    public  class ProductSaleDal:EfEntityRepositoryBase<ProductSale, EloshDbContext>, IProductSaleDal   
    {
    }
}
