using EloshStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Entities.Dtos.AdviceDto
{
    public class AdviceProductSellDto :IDto
    {
        public int ProductId { get; set; }
        public decimal Kdv { get; set; }
        public double Komisyon { get; set; }
        public decimal Kargo { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal OtherFee { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
