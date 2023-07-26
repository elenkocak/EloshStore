using EloshStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Entities.Dtos.ProductPurchase
{
    public class ProductPurchaseListDto :IDto
    {
        public int Id { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string WholesalerName { get; set; }
        public string PurchasePlace { get; set; }
        public int? Stock { get; set; }
    }
}
