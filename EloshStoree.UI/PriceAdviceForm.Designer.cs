namespace EloshStoree.UI
{
    partial class PriceAdviceForm
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
            label1 = new Label();
            nudProductId = new NumericUpDown();
            label2 = new Label();
            nudKdv = new NumericUpDown();
            label3 = new Label();
            nudKomisyon = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKargo = new TextBox();
            txtServiceFee = new TextBox();
            txtDigerHarcamalar = new TextBox();
            label7 = new Label();
            txtPurchasePrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKomisyon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductId";
            // 
            // nudProductId
            // 
            nudProductId.Location = new Point(128, 38);
            nudProductId.Name = "nudProductId";
            nudProductId.Size = new Size(78, 23);
            nudProductId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 85);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Kdv Oranı(%) :";
            // 
            // nudKdv
            // 
            nudKdv.Location = new Point(128, 83);
            nudKdv.Name = "nudKdv";
            nudKdv.Size = new Size(78, 23);
            nudKdv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 124);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Komisyon(%) :";
            // 
            // nudKomisyon
            // 
            nudKomisyon.Location = new Point(128, 122);
            nudKomisyon.Name = "nudKomisyon";
            nudKomisyon.Size = new Size(78, 23);
            nudKomisyon.TabIndex = 5;
            nudKomisyon.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 167);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Kargo Ücreti:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 202);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 7;
            label5.Text = "Hizmet Bedeli:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 238);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 8;
            label6.Text = "Diğer Harcamalar:";
            // 
            // txtKargo
            // 
            txtKargo.Location = new Point(131, 163);
            txtKargo.Name = "txtKargo";
            txtKargo.Size = new Size(75, 23);
            txtKargo.TabIndex = 9;
            // 
            // txtServiceFee
            // 
            txtServiceFee.Location = new Point(131, 194);
            txtServiceFee.Name = "txtServiceFee";
            txtServiceFee.Size = new Size(75, 23);
            txtServiceFee.TabIndex = 10;
            // 
            // txtDigerHarcamalar
            // 
            txtDigerHarcamalar.Location = new Point(131, 235);
            txtDigerHarcamalar.Name = "txtDigerHarcamalar";
            txtDigerHarcamalar.Size = new Size(75, 23);
            txtDigerHarcamalar.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 275);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "Alış Fiyatı:";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(131, 272);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(75, 23);
            txtPurchasePrice.TabIndex = 13;
            // 
            // PriceAdviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label7);
            Controls.Add(txtDigerHarcamalar);
            Controls.Add(txtServiceFee);
            Controls.Add(txtKargo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudKomisyon);
            Controls.Add(label3);
            Controls.Add(nudKdv);
            Controls.Add(label2);
            Controls.Add(nudProductId);
            Controls.Add(label1);
            Name = "PriceAdviceForm";
            Text = "PriceAdviceForm";
            ((System.ComponentModel.ISupportInitialize)nudProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKomisyon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudProductId;
        private Label label2;
        private NumericUpDown nudKdv;
        private Label label3;
        private NumericUpDown nudKomisyon;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKargo;
        private TextBox txtServiceFee;
        private TextBox txtDigerHarcamalar;
        private Label label7;
        private TextBox txtPurchasePrice;
    }
}