using EloshStore.BLL.Abstract;
using EloshStore.Dal.Abstract;
using EloshStore.Entities;
using EloshStore.Entities.Dtos.ProductSales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Concrete
{
    public class ProductSaleManager : IProductSaleService
    {
        private readonly IProductSaleDal _productSaleDal;
        private readonly IProductPurchaseDal _productPurchaseDal;
        private readonly IStockDal _stockDal;
        public ProductSaleManager(IProductSaleDal productSaleDal, IProductPurchaseDal productPurchaseDal, IStockDal stockDal)
        {
            _productSaleDal = productSaleDal;
            _productPurchaseDal = productPurchaseDal;
            _stockDal = stockDal;
        }

        private decimal ProfitCalculation(decimal salePrice, decimal purchasePrice, decimal shippingCost, decimal comission, decimal otherExpenses, decimal kdv, decimal? serviceFee, int totalProduct)
        {
            var totalPrice = salePrice * totalProduct;
            var comissionTotal = totalPrice * comission / 100;
            var kdvTotal = totalPrice * kdv / 100;
            var totalPurchasePrice=purchasePrice * totalProduct;    
            if (serviceFee==null)
            {
                serviceFee = 0;
            }
            var giderler = comissionTotal + kdvTotal + shippingCost + otherExpenses + totalPurchasePrice + serviceFee;
            var kar = totalPrice - giderler;
            return (decimal)kar;
        }
        private decimal GetPurchasePrice(int productId)
        {
            var getPurchasePrice = _productPurchaseDal.Get(x => x.Id == productId).PurchasePrice;
            return getPurchasePrice;
        }
        public bool AddProductSale(ProductSaleAddDto productSaleAddDto)
        {
            try
            {
                if (productSaleAddDto == null)
                {
                    return false;
                }
                var purchasePrice = GetPurchasePrice(productSaleAddDto.ProductId);
                var productSale = new ProductSale()
                {
                    SaleDate = DateTime.Now,
                    ProductId = productSaleAddDto.ProductId,
                    SalePrice = productSaleAddDto.SalePrice,
                    SoldQuantity = productSaleAddDto.SoldQuantity,
                    ShippingCost = productSaleAddDto.ShippingCost,
                    WhereSold = productSaleAddDto.WhereSold,
                    Commission = productSaleAddDto.Commission,
                    CostDescription = productSaleAddDto.CostDescription,
                    Kdv = productSaleAddDto.Kdv,
                    ServiceFee = productSaleAddDto.ServiceFee,
                    OtherExpenses = productSaleAddDto.OtherExpenses,
                    Profit = ProfitCalculation(productSaleAddDto.SalePrice, purchasePrice, productSaleAddDto.ShippingCost, productSaleAddDto.Commission, productSaleAddDto.OtherExpenses, productSaleAddDto.Kdv, productSaleAddDto.ServiceFee, productSaleAddDto.SoldQuantity),

                };
                _productSaleDal.Add(productSale);
                var matchProductIdInStock = _stockDal.Get(x => x.ProductId == productSale.ProductId);
                if (matchProductIdInStock==null) //Stoklarda böyle bir ürün bulunamadı
                {
                    return false;   
                }
                var azalanStok = matchProductIdInStock.InStock - productSale.SoldQuantity;
                if (azalanStok < 0)
                {
                    azalanStok = 0;
                }
                var stockUpdate = new Stock
                {
                    Id = matchProductIdInStock.Id,
                    ProductId = matchProductIdInStock.ProductId,
                    ProductName = matchProductIdInStock.ProductName,
                    Description = matchProductIdInStock.Description,
                    InStock = azalanStok,
                };
                _stockDal.Update(stockUpdate);
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool DeleteProductSale(int id)
        {
            try
            {
                if (id==null)
                {
                    return false;
                }
                var getProductSale = _productSaleDal.Get(x => x.Id == id);
                if (getProductSale != null)
                {
                    _productSaleDal.Delete(getProductSale);
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        //SONRA YAPILACAK
        //public List<ProductSaleListDto> SaleSummary()
        //{
        //    try
        //    {
        //        var salesList = _productSaleDal.GetList();
        //        var saleListDto = new List<SaleSummaryDto>();

        //        foreach (var item in salesList)
        //        {
        //            var productDetail = _productPurchaseDal.Get(x => x.Id == item.ProductId);

        //            saleListDto.Add(new SaleSummaryDto
        //            {
        //                Id=item.Id,
        //                SaleDate=item.SaleDate,
        //                SalePrice=item.SalePrice,
        //                ProductName= productDetail.ProductName,
        //                SoldQuantity=item.SoldQuantity,
        //                PurchasePrice=$"{ productDetail.PurchasePrice.ToString()} + ₺" ,  

        //            });
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}

        public ProductSaleListDto GetProductById(int productId)
        {
            try
            {
                if (productId==null)
                {
                    return null;
                }
                var getProduct = _productSaleDal.Get(x => x.ProductId == productId);
                if (getProduct!= null)
                {
                    var productSaleListDto = new ProductSaleListDto()
                    {
                        Id = getProduct.Id,
                        ProductId = getProduct.ProductId,
                        SaleDate = getProduct.SaleDate,
                        SalePrice = getProduct.SalePrice,
                        SoldQuantity = getProduct.SoldQuantity,
                        Profit = getProduct.Profit,
                        ShippingCost = getProduct.ShippingCost,
                        Commission = getProduct.Commission,
                        CostDescription = getProduct.CostDescription,
                        WhereSold = getProduct.WhereSold,
                        OtherExpenses = getProduct.OtherExpenses,
                        Kdv = getProduct.Kdv,
                        ServiceFee = getProduct.ServiceFee,
                       
                    };    
                    return productSaleListDto;
                }
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public ProductSaleListDto GetProductSaleById(int id)
        {
            try
            {
                if (id != null)
                {
                    var getProduct = _productSaleDal.Get(x => x.Id == id);
                    var productDetail = _productPurchaseDal.Get(x => x.Id == getProduct.ProductId);
                    if (getProduct != null)
                    {
                        var dto = new ProductSaleListDto
                        {
                            Id = getProduct.Id,
                            ProductId = getProduct.ProductId,
                            SaleDate = getProduct.SaleDate,
                            SalePrice = getProduct.SalePrice,
                            SoldQuantity = getProduct.SoldQuantity,
                            Profit = getProduct.Profit,
                            ShippingCost = getProduct.ShippingCost,
                            Commission = getProduct.Commission,
                            CostDescription = getProduct.CostDescription,
                            WhereSold = getProduct.WhereSold,
                            OtherExpenses = getProduct.OtherExpenses,
                            Kdv = getProduct.Kdv,
                            ServiceFee = getProduct.ServiceFee,
                            ProductName = productDetail.ProductName,
                            PurchasePrice = productDetail.PurchasePrice,


                        };
                        return dto;
                    }
                }
                return null;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<ProductSaleListDto> ListProductSale()
        {
            var productSaleEntity = _productSaleDal.GetList();
            var productSaleListDto = new List<ProductSaleListDto>();
            foreach (var item in productSaleEntity)
            {
                var productDetail = _productPurchaseDal.Get(x => x.Id == item.ProductId);
                productSaleListDto.Add(new ProductSaleListDto
                {
                    Id = item.Id,
                    ProductName = _productPurchaseDal.Get(x => x.Id == item.ProductId).ProductName,
                    SaleDate = item.SaleDate,
                    SalePrice = item.SalePrice,
                    ProductId = item.ProductId,
                    SoldQuantity = item.SoldQuantity,
                    CostDescription = item.CostDescription,
                    Commission = item.Commission,
                    ServiceFee = item.ServiceFee,
                    Kdv = item.Kdv,
                    OtherExpenses = item.OtherExpenses,
                    Profit = item.Profit,
                    PurchasePrice = productDetail.PurchasePrice,
                    ShippingCost = item.ShippingCost,
                    WhereSold = item.WhereSold,
                    
                });
            }
            return productSaleListDto;
        }

        public bool UpdateProductSale(ProductSaleUpdateDto productSaleUpdateDto)
        {
            try
            {
                if (productSaleUpdateDto != null)
                {
                    var updateEntity = _productSaleDal.Get(x => x.Id == productSaleUpdateDto.Id);
                    var purchasePrice = _productPurchaseDal.Get(x => x.Id == productSaleUpdateDto.ProductId);

                    

                    updateEntity.Id = productSaleUpdateDto.Id;
                    updateEntity.ProductId = productSaleUpdateDto.ProductId;
                    updateEntity.SalePrice = productSaleUpdateDto.SalePrice;
                    updateEntity.SoldQuantity = productSaleUpdateDto.SoldQuantity;
                    updateEntity.SaleDate = productSaleUpdateDto.SaleDate;
                    updateEntity.UpdateDate = DateTime.Now;
                    updateEntity.Profit = ProfitCalculation(productSaleUpdateDto.SalePrice, purchasePrice.PurchasePrice, productSaleUpdateDto.ShippingCost, productSaleUpdateDto.Commission, productSaleUpdateDto.OtherExpenses, productSaleUpdateDto.Kdv, productSaleUpdateDto.ServiceFee==null ? 0 : productSaleUpdateDto.ServiceFee, productSaleUpdateDto.SoldQuantity );
                    updateEntity.ShippingCost = productSaleUpdateDto.ShippingCost;
                    updateEntity.Commission = productSaleUpdateDto.Commission;
                    updateEntity.CostDescription = productSaleUpdateDto.CostDescription;
                    updateEntity.WhereSold = productSaleUpdateDto.WhereSold;
                    updateEntity.OtherExpenses = productSaleUpdateDto.OtherExpenses;

                    updateEntity.Kdv = productSaleUpdateDto.Kdv;
                    updateEntity.ServiceFee = productSaleUpdateDto.ServiceFee;

                    _productSaleDal.Update(updateEntity);
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
