using EloshStore.BLL.Abstract;
using EloshStore.BLL.Constants;
using EloshStore.Core.Result;
using EloshStore.Dal.Abstract;
using EloshStore.Entities;
using EloshStore.Entities.Dtos.ProductPurchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Concrete
{
    public class ProductPurchaseManager : IProductPurchaseService
    {
        private readonly IProductPurchaseDal _productPurchaseDal;
        private readonly IStockDal _stockDal;
        public ProductPurchaseManager(IProductPurchaseDal productPurchaseDal, IStockDal stockDal)
        {
            _productPurchaseDal = productPurchaseDal;
            _stockDal = stockDal;
        }

        public bool AddProductPurchase(ProductPurchaseAddDto productPurchaseAddDto)
        {
            try
            {
                var addProductPurchase = new ProductPurchase()
                {
                    ProductName = productPurchaseAddDto.ProductName,
                    ProductType = productPurchaseAddDto.ProductType,
                    Description = productPurchaseAddDto.Description,
                    PurchaseDate = DateTime.Now,
                    PurchasePlace = productPurchaseAddDto.PurchasePlace,
                    PurchasePrice = productPurchaseAddDto.PurchasePrice,
                    WholesalerName = productPurchaseAddDto.WholesalerName,
                    Stock = productPurchaseAddDto.Stock,
                   
                };
                _productPurchaseDal.Add(addProductPurchase);
                var stockAdd = new Stock()
                {
                    InStock= addProductPurchase.Stock,
                    Description = addProductPurchase.Description,
                    ProductId= addProductPurchase.Id,
                    ProductName= addProductPurchase.ProductName,
                };
                _stockDal.Add(stockAdd);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public ProductPurchaseListDto GetProductPurchaseById(int id)
        {
            try
            {
                var get = _productPurchaseDal.Get(x => x.Id == id);
                if (get != null)
                {
                    var dto = new ProductPurchaseListDto
                    {
                        Id = get.Id,
                        Description = get.Description,
                        PurchaseDate = get.PurchaseDate,
                        ProductImage = get.ProductImage,
                        Stock = get.Stock,
                        ProductName = get.ProductName,
                        ProductType = get.ProductType,
                        PurchasePlace = get.PurchasePlace,
                        PurchasePrice = get.PurchasePrice,
                        WholesalerName = get.WholesalerName
                    };
                    return dto;
                }
                return null;
            }
            catch (Exception e)
            {

                throw;
            }

        }

        public List<ProductPurchaseListDto> ListProductPurchase()
        {
            try
            {
                var getProduct = _productPurchaseDal.GetList();
                var getProductPurchaseDto = new List<ProductPurchaseListDto>();
                foreach (var item in getProduct)
                {
                    getProductPurchaseDto.Add(new ProductPurchaseListDto
                    {
                        Id = item.Id,
                        Description = item.Description,
                        ProductImage = item.ProductImage,
                        ProductName = item.ProductName,
                        ProductType = item.ProductType,
                        PurchasePlace = item.PurchasePlace,
                        PurchaseDate = item.PurchaseDate,
                        PurchasePrice = item.PurchasePrice,
                        Stock = item.Stock,
                        WholesalerName = item.WholesalerName

                    });
                }
                return getProductPurchaseDto;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveProductPurchase(int id)
        {
            try
            {
                var getProduct = _productPurchaseDal.Get(x => x.Id == id);
                if (getProduct != null)
                {
                    _productPurchaseDal.Delete(getProduct);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool UpdateProductPurchase(ProductPurchaseUpdateDto productPurchaseUpdateDto)
        {
            try
            {
                var getProduct = _productPurchaseDal.Get(x => x.Id == productPurchaseUpdateDto.Id);
                if (getProduct != null)
                {

                    getProduct.Id = productPurchaseUpdateDto.Id;
                    getProduct.Description = productPurchaseUpdateDto.Description;
                    getProduct.Stock = productPurchaseUpdateDto.Stock;
                    getProduct.PurchaseDate = productPurchaseUpdateDto.PurchaseDate;
                    getProduct.ProductImage = productPurchaseUpdateDto.ProductImage;
                    getProduct.ProductName = productPurchaseUpdateDto.ProductName;
                    getProduct.ProductType = productPurchaseUpdateDto.ProductType;
                    getProduct.PurchasePlace = productPurchaseUpdateDto.PurchasePlace;
                    getProduct.PurchasePrice = productPurchaseUpdateDto.PurchasePrice;
                    getProduct.WholesalerName = productPurchaseUpdateDto.WholesalerName;
                    getProduct.UpdateDate = DateTime.Now;   
                       
                    _productPurchaseDal.Update(getProduct);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
