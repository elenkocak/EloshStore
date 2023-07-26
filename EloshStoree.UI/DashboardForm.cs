using EloshStore.BLL.Abstract;
using EloshStore.BLL.Concrete;
using EloshStoree.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EloshStore.UIü
{
    public partial class DashboardForm : Form
    {
        private readonly IProductPurchaseService _purchaseService;
        private readonly IProductSaleService _saleService;
        private readonly IStockService _stockService;
        public DashboardForm(IProductPurchaseService purchaseService, IProductSaleService saleService, IStockService stockService)
        {
            _purchaseService = purchaseService;
            _saleService = saleService;
            _stockService = stockService;
        }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //ÜRÜNLER BUTONU
        ProductFrom productFrom;
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productFrom == null)
            {
                productFrom = new ProductFrom(_purchaseService);
                productFrom.MdiParent = this;
                productFrom.Show();
            }

        }

        private void g_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        StockForm stockForm;
        private void btnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stockForm==null)
            {
                stockForm = new StockForm(_stockService);
                stockForm.MdiParent=this;
                stockForm.Show();   
            }
        }

        ProductSellForm productSellForm;
        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productSellForm==null)
            {
                productSellForm = new ProductSellForm(_saleService, _stockService, _purchaseService);
                productSellForm.MdiParent = this;
                productSellForm.Show();
            }
        }
    }
}
