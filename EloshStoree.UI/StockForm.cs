using EloshStore.BLL.Abstract;
using EloshStore.Entities.Dtos.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EloshStoree.UI
{
    public partial class StockForm : Form
    {
        private readonly IStockService _stockService;
        public StockForm(IStockService stockService)
        {
            InitializeComponent();
            _stockService = stockService;
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            var stocklist = _stockService.GetStockList();
            gridControl1.DataSource = stocklist;
            gridView1.BestFitColumns();// kolonları en uygun şekilde genişletir.

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStockEkle_Click(object sender, EventArgs e)
        {
            var stockDto = new StockAddDto()
            {
                Description = txtDescription.Text,
                InStock = Convert.ToInt32(txtStock.Text),
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
            };
            if (stockDto == null)
            {
                MessageBox.Show("Stok Eklenirken Bir Hata Oluştu.");
            }
            var addStock = _stockService.AddStock(stockDto);
            if (addStock != null)
            {
                MessageBox.Show("Stok Eklendi.");
            }
        }

        private void btnStockSil_Click(object sender, EventArgs e)
        {
            var deleteStock = _stockService.DeleteStock(Convert.ToInt32(txtStockId.Text));
            if (deleteStock != null)
            {
                MessageBox.Show("Stok Silindi.");
            }
            MessageBox.Show("Stok Silinirken Bir Hata Oluştu.");
        }

        private void btnStokListele_Click(object sender, EventArgs e)
        {
            var stocklist = _stockService.GetStockList();
            gridControl1.DataSource = stocklist;
        }

        private void btnStockGüncelle_Click(object sender, EventArgs e)
        {
            var updateDto = new StockUpdateDto()
            {
                Description = txtDescription.Text,
                InStock = Convert.ToInt32(txtStock.Text),
                Id = Convert.ToInt32(txtStockId.Text),
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
            };
            var updateStock = _stockService.UpdateStock(updateDto);
            if (updateStock != null)
            {
                MessageBox.Show("Stok Güncellendi");
            }
        }

        private void txtStockId_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int result) || txtProductId.Text == null)
            {
                // Eğer dönüşüm başarısız olursa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir 'Ürün Id'si  giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Text = string.Empty;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStock.Text, out int result) || txtProductId.Text == null)
            {
                // Eğer dönüşüm başarısız olursa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir 'Stok adedi'  giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Text = string.Empty;
            }
        }
    }
}
