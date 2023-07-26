namespace EloshStore.UIü
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnProducts = new DevExpress.XtraBars.BarButtonItem();
            btnStocks = new DevExpress.XtraBars.BarButtonItem();
            btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            S = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            btnStok = new DevExpress.XtraBars.BarButtonItem();
            btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            popupMenu3 = new DevExpress.XtraBars.PopupMenu(components);
            btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            btnKasa = new DevExpress.XtraBars.BarButtonItem();
            btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            popupMenu2 = new DevExpress.XtraBars.PopupMenu(components);
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu2).BeginInit();
            SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new Padding(35);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnProducts, btnStocks, btnCustomers, S, barButtonItem5, btnAnasayfa, btnUrunler, btnStok, btnMusteriler, btnGiderler, btnKasa, btnNotlar, btnAyarlar, barButtonItem1 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.Margin = new Padding(4, 3, 4, 3);
            ribbonControl1.MaxItemId = 28;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 385;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage2 });
            ribbonControl1.Size = new Size(1247, 150);
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below;
            // 
            // btnProducts
            // 
            btnProducts.Caption = "ÜRÜNLER";
            btnProducts.Id = 1;
            btnProducts.ImageOptions.Image = (Image)resources.GetObject("btnProducts.ImageOptions.Image");
            btnProducts.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ItemAppearance.Normal.Options.UseFont = true;
            btnProducts.Name = "btnProducts";
            btnProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnProducts.ItemClick += barButtonItem1_ItemClick;
            // 
            // btnStocks
            // 
            btnStocks.Caption = "STOKLAR";
            btnStocks.Id = 2;
            btnStocks.ImageOptions.Image = (Image)resources.GetObject("btnStocks.ImageOptions.Image");
            btnStocks.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStocks.ItemAppearance.Normal.Options.UseFont = true;
            btnStocks.Name = "btnStocks";
            btnStocks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnStocks.ItemClick += barButtonItem2_ItemClick;
            // 
            // btnCustomers
            // 
            btnCustomers.Caption = "MÜŞTERİLER";
            btnCustomers.Id = 3;
            btnCustomers.ImageOptions.Image = (Image)resources.GetObject("btnCustomers.ImageOptions.Image");
            btnCustomers.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomers.ItemAppearance.Normal.Options.UseFont = true;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // S
            // 
            S.Caption = "ANASAYFA";
            S.Id = 4;
            S.Name = "S";
            // 
            // barButtonItem5
            // 
            barButtonItem5.ActAsDropDown = true;
            barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            barButtonItem5.Caption = "barButtonItem5";
            barButtonItem5.DropDownControl = popupMenu1;
            barButtonItem5.Id = 5;
            barButtonItem5.Name = "barButtonItem5";
            // 
            // popupMenu1
            // 
            popupMenu1.Name = "popupMenu1";
            popupMenu1.Ribbon = ribbonControl1;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.Caption = "ANASAYFA";
            btnAnasayfa.Id = 9;
            btnAnasayfa.ImageOptions.Image = (Image)resources.GetObject("btnAnasayfa.ImageOptions.Image");
            btnAnasayfa.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            btnAnasayfa.LargeWidth = 100;
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnUrunler
            // 
            btnUrunler.Caption = "ÜRÜNLER";
            btnUrunler.Id = 10;
            btnUrunler.ImageOptions.Image = (Image)resources.GetObject("btnUrunler.ImageOptions.Image");
            btnUrunler.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            btnUrunler.LargeWidth = 70;
            btnUrunler.Name = "btnUrunler";
            btnUrunler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnUrunler.ItemClick += barButtonItem1_ItemClick_1;
            // 
            // btnStok
            // 
            btnStok.Caption = "STOKLAR";
            btnStok.Id = 11;
            btnStok.ImageOptions.Image = (Image)resources.GetObject("btnStok.ImageOptions.Image");
            btnStok.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStok.ItemAppearance.Normal.Options.UseFont = true;
            btnStok.LargeWidth = 100;
            btnStok.Name = "btnStok";
            btnStok.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnStok.ItemClick += btnStok_ItemClick;
            // 
            // btnMusteriler
            // 
            btnMusteriler.ActAsDropDown = true;
            btnMusteriler.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            btnMusteriler.Caption = "MÜŞTERİLER";
            btnMusteriler.DropDownControl = popupMenu3;
            btnMusteriler.Id = 12;
            btnMusteriler.ImageOptions.Image = (Image)resources.GetObject("btnMusteriler.ImageOptions.Image");
            btnMusteriler.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu3
            // 
            popupMenu3.Name = "popupMenu3";
            popupMenu3.Ribbon = ribbonControl1;
            // 
            // btnGiderler
            // 
            btnGiderler.Caption = "GİDERLER";
            btnGiderler.Id = 13;
            btnGiderler.ImageOptions.Image = (Image)resources.GetObject("btnGiderler.ImageOptions.Image");
            btnGiderler.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            btnGiderler.LargeWidth = 100;
            btnGiderler.Name = "btnGiderler";
            btnGiderler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            btnGiderler.ItemClick += g_ItemClick;
            // 
            // btnKasa
            // 
            btnKasa.Caption = "KASA";
            btnKasa.Id = 14;
            btnKasa.ImageOptions.Image = (Image)resources.GetObject("btnKasa.ImageOptions.Image");
            btnKasa.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            btnKasa.LargeWidth = 50;
            btnKasa.Name = "btnKasa";
            btnKasa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNotlar
            // 
            btnNotlar.Caption = "NOTLAR";
            btnNotlar.Id = 15;
            btnNotlar.ImageOptions.Image = (Image)resources.GetObject("btnNotlar.ImageOptions.Image");
            btnNotlar.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            btnNotlar.LargeWidth = 90;
            btnNotlar.Name = "btnNotlar";
            btnNotlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Caption = "AYARLAR";
            btnAyarlar.Id = 16;
            btnAyarlar.ImageOptions.Image = (Image)resources.GetObject("btnAyarlar.ImageOptions.Image");
            btnAyarlar.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            btnAyarlar.LargeWidth = 70;
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "ÜRÜN SATIŞ";
            barButtonItem1.Id = 18;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick_2;
            // 
            // ribbonPage2
            // 
            ribbonPage2.Appearance.BackColor = Color.Gray;
            ribbonPage2.Appearance.Options.UseBackColor = true;
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ELOSH STORE STOK TAKİP SİSTEMİ";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnAnasayfa);
            ribbonPageGroup3.ItemLinks.Add(btnUrunler);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem1, true);
            ribbonPageGroup3.ItemLinks.Add(btnStok);
            ribbonPageGroup3.ItemLinks.Add(btnMusteriler, true);
            ribbonPageGroup3.ItemLinks.Add(btnGiderler);
            ribbonPageGroup3.ItemLinks.Add(btnKasa);
            ribbonPageGroup3.ItemLinks.Add(btnNotlar);
            ribbonPageGroup3.ItemLinks.Add(btnAyarlar);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(S);
            ribbonPageGroup2.ItemLinks.Add(btnProducts);
            ribbonPageGroup2.ItemLinks.Add(btnStocks);
            ribbonPageGroup2.ItemLinks.Add(btnCustomers);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // popupMenu2
            // 
            popupMenu2.Name = "popupMenu2";
            popupMenu2.Ribbon = ribbonControl1;
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 724);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu3).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnStocks;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.BarButtonItem S;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnStok;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
    }
}

