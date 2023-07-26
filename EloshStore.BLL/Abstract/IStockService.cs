using EloshStore.Entities.Dtos.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Abstract
{
    public interface IStockService
    {
        bool AddStock(StockAddDto stockAddDto);
        bool UpdateStock(StockUpdateDto stockUpdateDto);    
        StockListDto GetStockById(int id);
        List<StockListDto> GetStockList();
        bool DeleteStock(int id);
        StockListDto GetProducByIdInStock(int productId);
    }
}
