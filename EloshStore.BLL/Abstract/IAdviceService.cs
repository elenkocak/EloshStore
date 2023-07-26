using EloshStore.Entities.Dtos.AdviceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Abstract
{
    public interface IAdviceService
    {
        object AdviceSalePrice(AdviceProductSellDto adviceProductSellDto);
    }
}
