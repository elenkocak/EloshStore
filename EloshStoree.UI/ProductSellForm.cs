using DevExpress.Data.Filtering.Helpers;
using DevExpress.Utils.About;
using DevExpress.XtraEditors.Behaviors;
using EloshStore.BLL.Abstract;
using EloshStore.Dal.Abstract;
using EloshStore.Entities;
using EloshStore.Entities.Dtos.ProductSales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace EloshStoree.UI
{
    public partial class ProductSellForm : Form
    {
        private readonly IProductSaleService _productSaleService;
        private readonly IStockService _stockService;
        private readonly IProductPurchaseService _productPurchaseService;
        public ProductSellForm(IProductSaleService productSaleService, IStockService stockService, IProductPurchaseService productPurchaseService)
        {
            InitializeComponent();
            _productSaleService = productSaleService;
            _stockService = stockService;
            _productPurchaseService = productPurchaseService;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalePrice.Text) || string.IsNullOrEmpty(txtKomisyon.Text) || string.IsNullOrEmpty(txtServiceFee.Text) || string.IsNullOrEmpty(txtPlatform.Text) || string.IsNullOrEmpty(txtKargo.Text) || string.IsNullOrEmpty(txtDigerMasraflar.Text) || string.IsNullOrEmpty(txtKdv.Text) || string.IsNullOrEmpty(txtKomisyon.Text) || string.IsNullOrEmpty(txtServiceFee.Text) || string.IsNullOrEmpty(txtPlatform.Text))
            {
                MessageBox.Show("İlgili alanlar boş geçilemez! ");
            }
            var addProductSale = new ProductSaleAddDto()
            {
                ProductId = Convert.ToInt32(nudProductId.Value),
                SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                SoldQuantity = Convert.ToInt32(nudSoldQuantity.Value),
                CostDescription = txtMasrafAciklama.Text.ToLower(),
                WhereSold = txtPlatform.Text.ToLower(),
                Kdv = Convert.ToDecimal(txtKdv.Text),
                OtherExpenses = Convert.ToDecimal(txtDigerMasraflar.Text),
                Commission = Convert.ToDecimal(txtKomisyon.Text),
                ShippingCost = Convert.ToDecimal(txtKargo.Text),
                ServiceFee = Convert.ToDecimal(txtServiceFee.Text),

            };

            var productIfExists = _productSaleService.GetProductById(addProductSale.ProductId);
            if (productIfExists != null)
            {

                var stockMatch = _stockService.GetProducByIdInStock(addProductSale.ProductId);
                var product = _productPurchaseService.GetProductPurchaseById(addProductSale.ProductId);
                if (Convert.ToInt32(nudSoldQuantity.Value) > stockMatch.InStock)
                {
                    MessageBox.Show($"Satılan adet stok adetinden büyük olamaz ! Ürün: {product.ProductName + " ,"}  Kalan Stok:{stockMatch.InStock}");
                }
                if (productIfExists.ProductId != null && stockMatch.InStock <= 0)
                {
                    MessageBox.Show("Stoğu  bitmiş bir ürünü satamazsın !");
                }
            }

            var addSale = _productSaleService.AddProductSale(addProductSale);
            if (addSale != null)
            {
                MessageBox.Show("Satış Eklendi.");
            }
            else
            {
                MessageBox.Show("Satış Eklenemedi !");
            }
        }

        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{
        //    var updateProduct = new ProductSaleUpdateDto()
        //    {
        //        SalePrice = Convert.ToDecimal(txtSalePrice.Text),
        //        ProductId = Convert.ToInt32(nudProductId.Value),
        //        SoldQuantity = Convert.ToInt32(nudSoldQuantity.Value),

        //    };
        //    var updateProductSale = _productSaleService.UpdateProductSale(updateProduct);
        //    if (updateProductSale != null)
        //    {
        //        MessageBox.Show("Ürün Güncellendi");
        //    }
        //    MessageBox.Show("Ürün Güncellenemedi ! ");
        //}

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            var updateProduct = new ProductSaleUpdateDto()
            {
                Id = Convert.ToInt32(nudId.Value),
                ProductId = Convert.ToInt32(nudProductId.Value),
                SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                SoldQuantity = Convert.ToInt32(nudSoldQuantity.Value),
                ShippingCost = Convert.ToDecimal(txtKargo.Text),
                OtherExpenses = Convert.ToDecimal(txtDigerMasraflar.Text),
                CostDescription = txtMasrafAciklama.Text.ToLower(),
                Kdv = Convert.ToDecimal(txtKdv.Text),
                Commission = Convert.ToDecimal(txtKomisyon.Text),
                ServiceFee = Convert.ToDecimal(txtServiceFee.Text),
                WhereSold = txtPlatform.Text.ToLower(),


            };
            var updateProductSale = _productSaleService.UpdateProductSale(updateProduct);
            if (updateProductSale == null)
            {
                MessageBox.Show("Ürün Güncellenemedi ! ");
            }
            MessageBox.Show("Ürün Güncellendi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           DialogResult resultYesOrNo= MessageBox.Show("Satışı silmek istediğinize emin misiniz?", "Satışı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultYesOrNo==DialogResult.Yes)
            {
                var deleteProduct = _productSaleService.DeleteProductSale(Convert.ToInt32(nudId.Value));
                if (deleteProduct==false)
                {
                    MessageBox.Show("Böyle bir satış kaydı bulunamadı");
                }
                else 
                {
                    
                }
            }
            else
            {
                
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var listProduct = _productSaleService.ListProductSale();

        }

        private void ProductSellForm_Load(object sender, EventArgs e)
        {
            var listProduct = _productSaleService.ListProductSale();
            gridControl1.DataSource = listProduct;
            gridView1.BestFitColumns();// kolonları en uygun şekilde genişletir.

        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            var listProduct = _productSaleService.ListProductSale();
            gridControl1.DataSource = listProduct;
            gridView1.BestFitColumns();// kolonları en uygun şekilde genişletir.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalePrice.Text, out decimal result) || txtSalePrice.Text == null)
            {
                // Eğer dönüşüm başarısız olursa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir 'Satış Fiyatı' giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalePrice.Text = string.Empty;
            }

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            var getProduct = _productPurchaseService.ListProductPurchase();
            gridControl1.DataSource = getProduct;
            gridView1.BestFitColumns();
        }

        private void txtKomisyon_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtKomisyon.Text, out decimal result))
            {
                MessageBox.Show("Lütfen geçerli bir 'Komisyon Tutarı' giriniz");
            }
        }

        private void txtServiceFee_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtServiceFee.Text, out decimal result))
            {
                MessageBox.Show("Lütfen geçerli bir 'Servis Ücreti' tutarı giriniz.");
            }

        }

        private void txtDigerMasraflar_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDigerMasraflar.Text, out decimal result))
            {
                MessageBox.Show("Lütfen geçerli bir 'Diğer Masraflar' tutarı giriniz.");
            }
        }

        private void txtKdv_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtKdv.Text, out decimal result))
                MessageBox.Show("Lütfen geçerli bir 'KDV' yüzdesi giriniz.");
            {

            }
        }
    }
}
