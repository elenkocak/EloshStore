using EloshStore.Core.Result;
using EloshStore.Entities;
using EloshStore.Entities.Dtos.ProductPurchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Abstract
{
    public interface IProductPurchaseService
    {
        bool AddProductPurchase(ProductPurchaseAddDto productPurchaseAddDto);
        bool UpdateProductPurchase(ProductPurchaseUpdateDto productPurchaseUpdateDto);
        List<ProductPurchaseListDto> ListProductPurchase();
        ProductPurchaseListDto GetProductPurchaseById(int id);
        bool RemoveProductPurchase(int id);
    }
}
