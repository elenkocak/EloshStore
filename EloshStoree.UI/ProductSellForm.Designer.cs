namespace EloshStoree.UI
{
    partial class ProductSellForm
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
            nudId = new NumericUpDown();
            nudProductId = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            nudSoldQuantity = new NumericUpDown();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnSatisListele = new Button();
            txtSalePrice = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtKargo = new TextBox();
            label7 = new Label();
            txtDigerMasraflar = new TextBox();
            c = new Label();
            txtMasrafAciklama = new TextBox();
            txtPlatform = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtKdv = new TextBox();
            txtKomisyon = new TextBox();
            label10 = new Label();
            txtServiceFee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoldQuantity).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 29);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1037, 662);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1078, 80);
            label1.Name = "label1";
            label1.Size = new Size(27, 18);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1078, 112);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 3;
            label2.Text = "Ürün Id:";
            // 
            // nudId
            // 
            nudId.Location = new Point(1188, 81);
            nudId.Name = "nudId";
            nudId.Size = new Size(61, 23);
            nudId.TabIndex = 4;
            // 
            // nudProductId
            // 
            nudProductId.Location = new Point(1188, 113);
            nudProductId.Name = "nudProductId";
            nudProductId.Size = new Size(59, 23);
            nudProductId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1078, 142);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 8;
            label4.Text = "Satış Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1078, 176);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 10;
            label5.Text = "Satılan Miktar:";
            // 
            // nudSoldQuantity
            // 
            nudSoldQuantity.Location = new Point(1185, 171);
            nudSoldQuantity.Name = "nudSoldQuantity";
            nudSoldQuantity.Size = new Size(59, 23);
            nudSoldQuantity.TabIndex = 11;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(1224, 404);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(113, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Satış Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(1078, 404);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(113, 29);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Satış Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1078, 452);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 29);
            btnSil.TabIndex = 14;
            btnSil.Text = "Satış Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatisListele
            // 
            btnSatisListele.Location = new Point(1224, 452);
            btnSatisListele.Name = "btnSatisListele";
            btnSatisListele.Size = new Size(113, 29);
            btnSatisListele.TabIndex = 15;
            btnSatisListele.Text = "Satışları Listele";
            btnSatisListele.UseVisualStyleBackColor = true;
            btnSatisListele.Click += btnSatisListele_Click;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(1188, 142);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(59, 23);
            txtSalePrice.TabIndex = 16;
            txtSalePrice.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1073, 232);
            label3.Name = "label3";
            label3.Size = new Size(158, 18);
            label3.TabIndex = 17;
            label3.Text = "Komisyon Kesintisi(%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1292, 86);
            label6.Name = "label6";
            label6.Size = new Size(103, 18);
            label6.TabIndex = 18;
            label6.Text = "Kargo Masrafı:";
            // 
            // txtKargo
            // 
            txtKargo.Location = new Point(1409, 81);
            txtKargo.Name = "txtKargo";
            txtKargo.Size = new Size(59, 23);
            txtKargo.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1292, 112);
            label7.Name = "label7";
            label7.Size = new Size(111, 18);
            label7.TabIndex = 21;
            label7.Text = "Diğer Masraflar:";
            // 
            // txtDigerMasraflar
            // 
            txtDigerMasraflar.Location = new Point(1409, 113);
            txtDigerMasraflar.Name = "txtDigerMasraflar";
            txtDigerMasraflar.Size = new Size(62, 23);
            txtDigerMasraflar.TabIndex = 22;
            txtDigerMasraflar.TextChanged += txtDigerMasraflar_TextChanged;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(1289, 142);
            c.Name = "c";
            c.Size = new Size(119, 18);
            c.TabIndex = 23;
            c.Text = "Masraf Açıklama:";
            // 
            // txtMasrafAciklama
            // 
            txtMasrafAciklama.Location = new Point(1409, 142);
            txtMasrafAciklama.Name = "txtMasrafAciklama";
            txtMasrafAciklama.Size = new Size(62, 23);
            txtMasrafAciklama.TabIndex = 24;
            // 
            // txtPlatform
            // 
            txtPlatform.Location = new Point(1237, 303);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(127, 23);
            txtPlatform.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1073, 303);
            label8.Name = "label8";
            label8.Size = new Size(113, 18);
            label8.TabIndex = 26;
            label8.Text = "Satılan Platform:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1292, 176);
            label9.Name = "label9";
            label9.Size = new Size(68, 18);
            label9.TabIndex = 27;
            label9.Text = "KDV(%):";
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(1409, 176);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(60, 23);
            txtKdv.TabIndex = 28;
            txtKdv.TextChanged += txtKdv_TextChanged;
            // 
            // txtKomisyon
            // 
            txtKomisyon.Location = new Point(1237, 232);
            txtKomisyon.Name = "txtKomisyon";
            txtKomisyon.Size = new Size(127, 23);
            txtKomisyon.TabIndex = 29;
            txtKomisyon.TextChanged += txtKomisyon_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1073, 270);
            label10.Name = "label10";
            label10.Size = new Size(118, 18);
            label10.TabIndex = 30;
            label10.Text = "Servis Ücreti (₺):";
            // 
            // txtServiceFee
            // 
            txtServiceFee.Location = new Point(1237, 270);
            txtServiceFee.Name = "txtServiceFee";
            txtServiceFee.Size = new Size(123, 23);
            txtServiceFee.TabIndex = 31;
            txtServiceFee.TextChanged += txtServiceFee_TextChanged;
            // 
            // ProductSellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 723);
            Controls.Add(txtServiceFee);
            Controls.Add(label10);
            Controls.Add(txtKomisyon);
            Controls.Add(txtKdv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPlatform);
            Controls.Add(txtMasrafAciklama);
            Controls.Add(c);
            Controls.Add(txtDigerMasraflar);
            Controls.Add(label7);
            Controls.Add(txtKargo);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtSalePrice);
            Controls.Add(btnSatisListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(nudSoldQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudProductId);
            Controls.Add(nudId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridControl1);
            Name = "ProductSellForm";
            Text = "Satış Ekle";
            Load += ProductSellForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoldQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label1;
        private Label label2;
        private NumericUpDown nudId;
        private NumericUpDown nudProductId;
        private Label label4;
        private Label label5;
        private NumericUpDown nudSoldQuantity;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnSatisListele;
        private TextBox txtSalePrice;
        private Label label3;
        private Label label6;
        private TextBox txtKargo;
        private Label label7;
        private TextBox txtDigerMasraflar;
        private Label c;
        private TextBox txtMasrafAciklama;
        private TextBox txtPlatform;
        private Label label8;
        private Label label9;
        private TextBox txtKdv;
        private TextBox txtKomisyon;
        private Label label10;
        private TextBox txtServiceFee;
    }
}