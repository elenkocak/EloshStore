using EloshStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Entities.Dtos.Stocks
{
    public class StockUpdateDto:IDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int InStock { get; set; }
        public string Description { get; set; }
    }
}
