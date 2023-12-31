﻿using DevExpress.XtraGrid.Columns;
using EloshStore.BLL.Abstract;
using EloshStore.BLL.Concrete;
using EloshStore.Entities;
using System;
using System.Collections.Concurrent;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using EloshStore.Entities.Dtos.ProductPurchase;
using System.Data;

namespace EloshStore.UIü
{
    public partial class ProductFrom : Form
    {
        private readonly IProductPurchaseService _purchaseService;
        public ProductFrom(IProductPurchaseService purchaseService)
        {
            InitializeComponent();
            _purchaseService = purchaseService;
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            EloshStore.Dal.Concrete.Context.EloshDbContext dbContext = new EloshStore.Dal.Concrete.Context.EloshDbContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.ProductPurchases.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.ProductPurchases.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void ProductFrom_Load(object sender, EventArgs e)
        {

            var test = _purchaseService.ListProductPurchase();
            gridControl1.DataSource = test;



            gridView1.BestFitColumns();// kolonları en uygun şekilde genişletir.
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var addProduct = new ProductPurchaseAddDto()
            {
                ProductName = txtProductName.Text,
                ProductType = comboboxProductType.Text,
                PurchasePrice = numericPurchasePrice.Value,
                WholesalerName = txtWholesalerName.Text,
                PurchasePlace = txtPurchasePlace.Text,
                Stock = Convert.ToInt32(numericStock.Value),
                PurchaseDate = datetimepickerPurchaseDate.Value,
                Description = textboxDescription.Text,
            };
            var isSuccess = _purchaseService.AddProductPurchase(addProduct);
            if (isSuccess == true)
            {
                MessageBox.Show("Ürün Eklendi");
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var deleteProduct = _purchaseService.RemoveProductPurchase(Convert.ToInt32(txtId.Text));
            if (deleteProduct == true)
            {
                MessageBox.Show("Ürün Silindi.");
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var product = new ProductPurchaseUpdateDto()
            {
                Id = Convert.ToInt32(txtId.Text),
                Description = textboxDescription.Text,
                ProductName = txtProductName.Text,
                PurchaseDate = datetimepickerPurchaseDate.Value,
                Stock = Convert.ToInt32(numericStock.Value),
                ProductType = comboboxProductType.Text,
                PurchasePlace = txtPurchasePlace.Text,
                PurchasePrice = numericPurchasePrice.Value,
                WholesalerName = txtWholesalerName.Text
            };
            var updateProduct = _purchaseService.UpdateProductPurchase(product);
            if (updateProduct != null)
            {
                MessageBox.Show("Ürün Güncellendi.");
            }
            else
            {
                MessageBox.Show("Ürün Güncellenemedi !");
            }
        }


    }
}
