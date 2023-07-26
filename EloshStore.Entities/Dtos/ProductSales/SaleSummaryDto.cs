using EloshStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Entities.Dtos.ProductSales
{
    public class SaleSummaryDto :IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal OtherExpenses { get; set; }
        public decimal? Profit { get; set; }
        public int SoldQuantity { get; set; }
        public decimal PieceProfit { get; set; }
        public DateTime? SaleDate { get; set; }

    }
}
