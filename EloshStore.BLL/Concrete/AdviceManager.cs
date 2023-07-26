using EloshStore.BLL.Abstract;
using EloshStore.Dal.Abstract;
using EloshStore.Entities.Dtos.AdviceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.BLL.Concrete
{
    public class AdviceManager : IAdviceService
    {
		private readonly IProductPurchaseDal _productPurchaseDal;

        public AdviceManager(IProductPurchaseDal productPurchaseDal)
        {
            _productPurchaseDal = productPurchaseDal;
        }

        public object AdviceSalePrice(AdviceProductSellDto adviceProductSellDto)
        {
			try
			{
				if (adviceProductSellDto==null)
				{
					return null;
				}
				var kdvOraniYüzde = adviceProductSellDto.Kdv;
				var urunMaliyeti = adviceProductSellDto.PurchasePrice + adviceProductSellDto.ServiceFee + adviceProductSellDto.Kargo + Convert.ToDecimal (adviceProductSellDto.Komisyon* 0.01) + adviceProductSellDto.OtherFee;

				var kdvHaricFiyat = urunMaliyeti * Convert.ToDecimal(1 + 0.02);
				var kdvMiktari = kdvHaricFiyat * kdvOraniYüzde / 100;
				var onerilenSatisFiyati = kdvHaricFiyat + kdvMiktari;
				return onerilenSatisFiyati;
			}
			catch (Exception e)
			{

				throw;
			}
        }
    }
}
