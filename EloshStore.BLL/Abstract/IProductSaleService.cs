using EloshStore.Entities.Dtos.ProductSales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Abstract
{
    public interface IProductSaleService
    {
        bool AddProductSale(ProductSaleAddDto productSaleAddDto);
        bool UpdateProductSale(ProductSaleUpdateDto productSaleUpdateDto);
        bool DeleteProductSale(int id);
        List<ProductSaleListDto> ListProductSale();
        ProductSaleListDto GetProductSaleById(int id);
        ProductSaleListDto GetProductById(int productId);
       
    }
}
