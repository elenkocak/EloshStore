namespace EloshStoree.UI
{
    partial class StockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtDescription = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            txtStockId = new TextBox();
            label5 = new Label();
            txtProductId = new TextBox();
            btnStockEkle = new Button();
            btnStockGüncelle = new Button();
            btnStockSil = new Button();
            btnStokListele = new Button();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(514, 433);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 84);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 175);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Stok Miktarı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 126);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Ürün Açıklaması";
            label3.Click += label3_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(695, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(695, 118);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(695, 167);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 6;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 55);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock Id:";
            // 
            // txtStockId
            // 
            txtStockId.Location = new Point(695, 52);
            txtStockId.Name = "txtStockId";
            txtStockId.Size = new Size(100, 23);
            txtStockId.TabIndex = 8;
            txtStockId.TextChanged += txtStockId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 214);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "ProductId";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(695, 211);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 23);
            txtProductId.TabIndex = 10;
            // 
            // btnStockEkle
            // 
            btnStockEkle.Location = new Point(632, 314);
            btnStockEkle.Name = "btnStockEkle";
            btnStockEkle.Size = new Size(92, 28);
            btnStockEkle.TabIndex = 11;
            btnStockEkle.Text = "StokEkle";
            btnStockEkle.UseVisualStyleBackColor = true;
            btnStockEkle.Click += btnStockEkle_Click;
            // 
            // btnStockGüncelle
            // 
            btnStockGüncelle.Location = new Point(591, 411);
            btnStockGüncelle.Name = "btnStockGüncelle";
            btnStockGüncelle.Size = new Size(161, 23);
            btnStockGüncelle.TabIndex = 12;
            btnStockGüncelle.Text = "Stok Güncelle";
            btnStockGüncelle.UseVisualStyleBackColor = true;
            btnStockGüncelle.Click += btnStockGüncelle_Click;
            // 
            // btnStockSil
            // 
            btnStockSil.Location = new Point(632, 348);
            btnStockSil.Name = "btnStockSil";
            btnStockSil.Size = new Size(92, 28);
            btnStockSil.TabIndex = 13;
            btnStockSil.Text = "Stok Sil";
            btnStockSil.UseVisualStyleBackColor = true;
            btnStockSil.Click += btnStockSil_Click;
            // 
            // btnStokListele
            // 
            btnStokListele.Location = new Point(591, 382);
            btnStokListele.Name = "btnStokListele";
            btnStokListele.Size = new Size(161, 23);
            btnStokListele.TabIndex = 14;
            btnStokListele.Text = "Stok Listele";
            btnStokListele.UseVisualStyleBackColor = true;
            btnStokListele.Click += btnStokListele_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 522);
            Controls.Add(btnStokListele);
            Controls.Add(btnStockSil);
            Controls.Add(btnStockGüncelle);
            Controls.Add(btnStockEkle);
            Controls.Add(txtProductId);
            Controls.Add(label5);
            Controls.Add(txtStockId);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridControl1);
            Name = "StockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtDescription;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtStockId;
        private Label label5;
        private TextBox txtProductId;
        private Button btnStockEkle;
        private Button btnStockGüncelle;
        private Button btnStockSil;
        private Button btnStokListele;
    }
}