using EloshStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Entities.Dtos.ProductSales
{
    public class ProductSaleListDto:IDto
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? SoldQuantity { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? Profit { get; set; }
        public string ProductName { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Commission { get; set; }
        public string CostDescription { get; set; }
        public string WhereSold { get; set; }
        public decimal? OtherExpenses { get; set; }
        public decimal? Kdv { get; set; }
        public decimal?  ServiceFee { get; set; }

    }
}
