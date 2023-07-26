using EloshStore.BLL.Abstract;
using EloshStore.Dal.Abstract;
using EloshStore.Entities;
using EloshStore.Entities.Dtos.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;
        private readonly IProductPurchaseDal _productPurchaseDal;   
        private readonly IProductSaleDal _productSaleDal;

        public StockManager(IStockDal stockDal, IProductPurchaseDal productPurchaseDal, IProductSaleDal productSaleDal)
        {
            _stockDal = stockDal;
            _productPurchaseDal = productPurchaseDal;
            _productSaleDal = productSaleDal;
        }

        public bool AddStock(StockAddDto stockAddDto)
        {
            try
            {
                if (stockAddDto==null)
                {
                    return false;
                }

                var addStock = new Stock
                {
                    Description = stockAddDto.Description,
                    ProductId = stockAddDto.ProductId,  
                    InStock = stockAddDto.InStock,
                    ProductName = stockAddDto.ProductName,  
                };
               _stockDal.Add(addStock);
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool DeleteStock(int id)
        {
            try
            {
                if (id==null)
                {
                    return false;
                }
                var getStockId = _stockDal.Get(x => x.Id == id);
                if (getStockId != null)
                {
                    _stockDal.Delete(getStockId);
                    return true;    
                }
                return false;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //public int CalculateStock(int purchaseTotal, int sellTotal)
        //{
        //    var stock = purchaseTotal - sellTotal;
        //    if (stock<0)
        //    {
        //        return 0;
        //    }
        //    return  stock;
        //}
        public StockListDto GetProducByIdInStock(int productId)
        {
            try
            {
                if (productId==null)
                {
                    return null;
                }
                var getProductInStock=_stockDal.Get(x=>x.ProductId == productId);
                var purchaseTotal = _productPurchaseDal.Get(x => x.Id == getProductInStock.ProductId).Stock;
                var sellTotal = _productSaleDal.Get(x => x.ProductId == getProductInStock.ProductId).SoldQuantity;
                var stockDto = new StockListDto
                {
                    Id = getProductInStock.Id,
                    Description = getProductInStock.Description,
                    ProductName = getProductInStock.ProductName,
                    InStock =getProductInStock.InStock,
                };
                return stockDto;
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public StockListDto GetStockById(int id)
        {
            try
            {
                if (id == null)
                {
                    return null;
                }
                var getStock = _stockDal.Get(x => x.Id == id);
                var purchaseTotal = _productPurchaseDal.Get(x => x.Id == getStock.ProductId).Stock;
                var sellTotal = _productSaleDal.Get(x => x.ProductId == getStock.ProductId).SoldQuantity;
                if (purchaseTotal<=sellTotal || purchaseTotal<=0)
                {
                    return null; //alınan adet satılan adetten az olamaz, alınan adet 0 ve 0 dan küçük olamaz
                }
                var stockDto = new StockListDto
                {
                    Id = getStock.Id,
                    Description = getStock.Description,
                    ProductName = getStock.ProductName,
                    InStock = purchaseTotal = purchaseTotal < sellTotal ? 0 : purchaseTotal - sellTotal
                };
                return stockDto;
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }

        public List<StockListDto> GetStockList()
        {
            try
            {
                var stocks = _stockDal.GetList();
                var getStocksListDto=new List<StockListDto>();

                foreach (var stock in stocks)
                {
                    var purchaseTotal = _productPurchaseDal.Get(x => x.Id == stock.ProductId).Stock;
                    var sellTotal=_productSaleDal.Get(x=>x.ProductId==stock.ProductId).SoldQuantity;
                  
                    getStocksListDto.Add(new StockListDto
                    {
                        Id=stock.Id,    
                        Description=stock.Description,
                        ProductName=stock.ProductName,
                        InStock=purchaseTotal= purchaseTotal<sellTotal ? 0 : purchaseTotal-sellTotal
                    });
                }
                return getStocksListDto;    
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public bool UpdateStock(StockUpdateDto stockUpdateDto)
        {
            try
            {
                if (stockUpdateDto ==null)
                {
                    return false;
                }
                var stock = _stockDal.Get(x => x.Id == stockUpdateDto.Id);
                if (stock != null)
                {
                  stock.InStock=stockUpdateDto.InStock; 
                  stock.ProductId=stockUpdateDto.ProductId; 
                  stock.ProductName=stockUpdateDto.ProductName; 
                  stock.Description=stockUpdateDto.Description; 
                  
                }
                _stockDal.Update(stock);
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
