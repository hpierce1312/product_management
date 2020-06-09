namespace Major_Project_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label productUnitPriceLabel;
            System.Windows.Forms.Label product_CostLabel;
            System.Windows.Forms.Label quantity_On_HandLabel;
            System.Windows.Forms.Label quantity_On_OrderLabel;
            System.Windows.Forms.Label product_Lead_TimeLabel;
            System.Windows.Forms.Label productReorderLevelLabel;
            System.Windows.Forms.Label productLineLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label yTDPurchasesLabel;
            System.Windows.Forms.Label yTDSalesLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorRegionLabel;
            System.Windows.Forms.Label state_ProvinceLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label websiteAddressLabel;
            System.Windows.Forms.Label classificationLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInUSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInChinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInNewYorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.YTDTotalPurchaseLabel = new System.Windows.Forms.Label();
            this.YTDAveragePurchaseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDatabaseDataSet = new Major_Project_3.ProductDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSortByDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByProductIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByProductPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByProductCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripFilterButton = new System.Windows.Forms.ToolStripButton();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.vendorIDComboBox = new System.Windows.Forms.ComboBox();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.product_CostTextBox = new System.Windows.Forms.TextBox();
            this.quantity_On_HandTextBox = new System.Windows.Forms.TextBox();
            this.quantity_On_OrderTextBox = new System.Windows.Forms.TextBox();
            this.product_Lead_TimeTextBox = new System.Windows.Forms.TextBox();
            this.productReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.productLineTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.yTDPurchasesTextBox = new System.Windows.Forms.TextBox();
            this.yTDSalesTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorRegionTextBox = new System.Windows.Forms.TextBox();
            this.state_ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.websiteAddressTextBox = new System.Windows.Forms.TextBox();
            this.classificationTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pRODUCTTableAdapter = new Major_Project_3.ProductDatabaseDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new Major_Project_3.ProductDatabaseDataSetTableAdapters.TableAdapterManager();
            this.vENDORTableAdapter = new Major_Project_3.ProductDatabaseDataSetTableAdapters.VENDORTableAdapter();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            productUnitPriceLabel = new System.Windows.Forms.Label();
            product_CostLabel = new System.Windows.Forms.Label();
            quantity_On_HandLabel = new System.Windows.Forms.Label();
            quantity_On_OrderLabel = new System.Windows.Forms.Label();
            product_Lead_TimeLabel = new System.Windows.Forms.Label();
            productReorderLevelLabel = new System.Windows.Forms.Label();
            productLineLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            yTDPurchasesLabel = new System.Windows.Forms.Label();
            yTDSalesLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorRegionLabel = new System.Windows.Forms.Label();
            state_ProvinceLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            websiteAddressLabel = new System.Windows.Forms.Label();
            classificationLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).BeginInit();
            this.pRODUCTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(25, 69);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(71, 15);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "*Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(25, 98);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(92, 15);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "*Product Name:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(25, 127);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(66, 15);
            vendorIDLabel.TabIndex = 6;
            vendorIDLabel.Text = "*Vendor ID:";
            // 
            // productUnitPriceLabel
            // 
            productUnitPriceLabel.AutoSize = true;
            productUnitPriceLabel.Location = new System.Drawing.Point(25, 156);
            productUnitPriceLabel.Name = "productUnitPriceLabel";
            productUnitPriceLabel.Size = new System.Drawing.Size(111, 15);
            productUnitPriceLabel.TabIndex = 8;
            productUnitPriceLabel.Text = "*Product Unit Price:";
            // 
            // product_CostLabel
            // 
            product_CostLabel.AutoSize = true;
            product_CostLabel.Location = new System.Drawing.Point(25, 185);
            product_CostLabel.Name = "product_CostLabel";
            product_CostLabel.Size = new System.Drawing.Size(84, 15);
            product_CostLabel.TabIndex = 10;
            product_CostLabel.Text = "*Product Cost:";
            // 
            // quantity_On_HandLabel
            // 
            quantity_On_HandLabel.AutoSize = true;
            quantity_On_HandLabel.Location = new System.Drawing.Point(25, 214);
            quantity_On_HandLabel.Name = "quantity_On_HandLabel";
            quantity_On_HandLabel.Size = new System.Drawing.Size(116, 15);
            quantity_On_HandLabel.TabIndex = 12;
            quantity_On_HandLabel.Text = "*Quantity-On-Hand:";
            // 
            // quantity_On_OrderLabel
            // 
            quantity_On_OrderLabel.AutoSize = true;
            quantity_On_OrderLabel.Location = new System.Drawing.Point(25, 243);
            quantity_On_OrderLabel.Name = "quantity_On_OrderLabel";
            quantity_On_OrderLabel.Size = new System.Drawing.Size(117, 15);
            quantity_On_OrderLabel.TabIndex = 14;
            quantity_On_OrderLabel.Text = "*Quantity-On-Order:";
            // 
            // product_Lead_TimeLabel
            // 
            product_Lead_TimeLabel.AutoSize = true;
            product_Lead_TimeLabel.Location = new System.Drawing.Point(25, 272);
            product_Lead_TimeLabel.Name = "product_Lead_TimeLabel";
            product_Lead_TimeLabel.Size = new System.Drawing.Size(116, 15);
            product_Lead_TimeLabel.TabIndex = 16;
            product_Lead_TimeLabel.Text = "*Product Lead-Time:";
            // 
            // productReorderLevelLabel
            // 
            productReorderLevelLabel.AutoSize = true;
            productReorderLevelLabel.Location = new System.Drawing.Point(25, 301);
            productReorderLevelLabel.Name = "productReorderLevelLabel";
            productReorderLevelLabel.Size = new System.Drawing.Size(131, 15);
            productReorderLevelLabel.TabIndex = 18;
            productReorderLevelLabel.Text = "*Product Reorder Level:";
            // 
            // productLineLabel
            // 
            productLineLabel.AutoSize = true;
            productLineLabel.Location = new System.Drawing.Point(25, 330);
            productLineLabel.Name = "productLineLabel";
            productLineLabel.Size = new System.Drawing.Size(82, 15);
            productLineLabel.TabIndex = 20;
            productLineLabel.Text = "*Product Line:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(25, 359);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(46, 15);
            brandLabel.TabIndex = 22;
            brandLabel.Text = "*Brand:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(25, 388);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(57, 15);
            discountLabel.TabIndex = 24;
            discountLabel.Text = "Discount:";
            // 
            // yTDPurchasesLabel
            // 
            yTDPurchasesLabel.AutoSize = true;
            yTDPurchasesLabel.Location = new System.Drawing.Point(25, 417);
            yTDPurchasesLabel.Name = "yTDPurchasesLabel";
            yTDPurchasesLabel.Size = new System.Drawing.Size(89, 15);
            yTDPurchasesLabel.TabIndex = 26;
            yTDPurchasesLabel.Text = "*YTDPurchases:";
            // 
            // yTDSalesLabel
            // 
            yTDSalesLabel.AutoSize = true;
            yTDSalesLabel.Location = new System.Drawing.Point(25, 446);
            yTDSalesLabel.Name = "yTDSalesLabel";
            yTDSalesLabel.Size = new System.Drawing.Size(62, 15);
            yTDSalesLabel.TabIndex = 28;
            yTDSalesLabel.Text = "*YTDSales:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(341, 69);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(82, 15);
            vendorNameLabel.TabIndex = 30;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorRegionLabel
            // 
            vendorRegionLabel.AutoSize = true;
            vendorRegionLabel.Location = new System.Drawing.Point(341, 98);
            vendorRegionLabel.Name = "vendorRegionLabel";
            vendorRegionLabel.Size = new System.Drawing.Size(87, 15);
            vendorRegionLabel.TabIndex = 32;
            vendorRegionLabel.Text = "Vendor Region:";
            // 
            // state_ProvinceLabel
            // 
            state_ProvinceLabel.AutoSize = true;
            state_ProvinceLabel.Location = new System.Drawing.Point(341, 127);
            state_ProvinceLabel.Name = "state_ProvinceLabel";
            state_ProvinceLabel.Size = new System.Drawing.Size(87, 15);
            state_ProvinceLabel.TabIndex = 34;
            state_ProvinceLabel.Text = "State/Province:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(341, 156);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(31, 15);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "City:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(341, 185);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(73, 15);
            postalCodeLabel.TabIndex = 38;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(341, 214);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(53, 15);
            countryLabel.TabIndex = 40;
            countryLabel.Text = "Country:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(341, 243);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(84, 15);
            emailAddressLabel.TabIndex = 42;
            emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(341, 272);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(91, 15);
            phoneNumberLabel.TabIndex = 44;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // websiteAddressLabel
            // 
            websiteAddressLabel.AutoSize = true;
            websiteAddressLabel.Location = new System.Drawing.Point(341, 301);
            websiteAddressLabel.Name = "websiteAddressLabel";
            websiteAddressLabel.Size = new System.Drawing.Size(97, 15);
            websiteAddressLabel.TabIndex = 46;
            websiteAddressLabel.Text = "Website Address:";
            // 
            // classificationLabel
            // 
            classificationLabel.AutoSize = true;
            classificationLabel.Location = new System.Drawing.Point(341, 330);
            classificationLabel.Name = "classificationLabel";
            classificationLabel.Size = new System.Drawing.Size(80, 15);
            classificationLabel.TabIndex = 48;
            classificationLabel.Text = "Classification:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(341, 359);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(78, 15);
            activeStatusLabel.TabIndex = 50;
            activeStatusLabel.Text = "Active Status:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(341, 388);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(41, 15);
            notesLabel.TabIndex = 52;
            notesLabel.Text = "Notes:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(341, 417);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(87, 15);
            contactNameLabel.TabIndex = 54;
            contactNameLabel.Text = "Contact Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsSourcedInUSAToolStripMenuItem,
            this.productsSourcedInChinaToolStripMenuItem,
            this.productsSourcedInNewYorkToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // productsSourcedInUSAToolStripMenuItem
            // 
            this.productsSourcedInUSAToolStripMenuItem.Name = "productsSourcedInUSAToolStripMenuItem";
            this.productsSourcedInUSAToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productsSourcedInUSAToolStripMenuItem.Text = "Products Sourced in USA";
            this.productsSourcedInUSAToolStripMenuItem.Click += new System.EventHandler(this.ProductsSourcedInUSAToolStripMenuItem_Click);
            // 
            // productsSourcedInChinaToolStripMenuItem
            // 
            this.productsSourcedInChinaToolStripMenuItem.Name = "productsSourcedInChinaToolStripMenuItem";
            this.productsSourcedInChinaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productsSourcedInChinaToolStripMenuItem.Text = "Products Sourced in China";
            this.productsSourcedInChinaToolStripMenuItem.Click += new System.EventHandler(this.ProductsSourcedInChinaToolStripMenuItem_Click);
            // 
            // productsSourcedInNewYorkToolStripMenuItem
            // 
            this.productsSourcedInNewYorkToolStripMenuItem.Name = "productsSourcedInNewYorkToolStripMenuItem";
            this.productsSourcedInNewYorkToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productsSourcedInNewYorkToolStripMenuItem.Text = "Products Sourced in New York";
            this.productsSourcedInNewYorkToolStripMenuItem.Click += new System.EventHandler(this.ProductsSourcedInNewYorkToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(58, 526);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(87, 27);
            this.calcBtn.TabIndex = 57;
            this.calcBtn.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.calcBtn, "Calculate\r\n");
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(177, 526);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(87, 27);
            this.refreshBtn.TabIndex = 58;
            this.refreshBtn.Text = "&Refresh";
            this.toolTip1.SetToolTip(this.refreshBtn, "Refresh");
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(299, 526);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(87, 27);
            this.exitBtn.TabIndex = 59;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "Exit");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // YTDTotalPurchaseLabel
            // 
            this.YTDTotalPurchaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YTDTotalPurchaseLabel.Location = new System.Drawing.Point(783, 483);
            this.YTDTotalPurchaseLabel.Name = "YTDTotalPurchaseLabel";
            this.YTDTotalPurchaseLabel.Size = new System.Drawing.Size(116, 26);
            this.YTDTotalPurchaseLabel.TabIndex = 61;
            // 
            // YTDAveragePurchaseLabel
            // 
            this.YTDAveragePurchaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YTDAveragePurchaseLabel.Location = new System.Drawing.Point(783, 537);
            this.YTDAveragePurchaseLabel.Name = "YTDAveragePurchaseLabel";
            this.YTDAveragePurchaseLabel.Size = new System.Drawing.Size(116, 26);
            this.YTDAveragePurchaseLabel.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "YTD total purchases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "YTD average purchases:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(625, 66);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(274, 400);
            this.listView.TabIndex = 56;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Purchase Amount";
            this.columnHeader2.Width = 132;
            // 
            // pRODUCTBindingNavigator
            // 
            this.pRODUCTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUCTBindingNavigator.BindingSource = this.pRODUCTBindingSource;
            this.pRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTBindingNavigatorSaveItem,
            this.toolStripSortByDropDown,
            this.toolStripSearchTextBox,
            this.toolStripSearchButton,
            this.toolStripFilterButton});
            this.pRODUCTBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.pRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCTBindingNavigator.Name = "pRODUCTBindingNavigator";
            this.pRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCTBindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.pRODUCTBindingNavigator.TabIndex = 1;
            this.pRODUCTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.productDatabaseDataSet;
            // 
            // productDatabaseDataSet
            // 
            this.productDatabaseDataSet.DataSetName = "ProductDatabaseDataSet";
            this.productDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pRODUCTBindingNavigatorSaveItem
            // 
            this.pRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTBindingNavigatorSaveItem.Image")));
            this.pRODUCTBindingNavigatorSaveItem.Name = "pRODUCTBindingNavigatorSaveItem";
            this.pRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pRODUCTBindingNavigatorSaveItem.Text = "Save";
            // 
            // toolStripSortByDropDown
            // 
            this.toolStripSortByDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSortByDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.sortByProductIDToolStripMenuItem,
            this.sortByProductPriceToolStripMenuItem,
            this.sortByProductCostToolStripMenuItem});
            this.toolStripSortByDropDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSortByDropDown.Image")));
            this.toolStripSortByDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSortByDropDown.Name = "toolStripSortByDropDown";
            this.toolStripSortByDropDown.Size = new System.Drawing.Size(29, 22);
            this.toolStripSortByDropDown.Text = "toolStripSortByDropDownBtn";
            this.toolStripSortByDropDown.ToolTipText = "Sort data";
//            this.toolStripSortByDropDown.Click += new System.EventHandler(this.ToolStripSortByDropDown_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nameToolStripMenuItem.Text = "Sort By Product Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.NameToolStripMenuItem_Click);
            // 
            // sortByProductIDToolStripMenuItem
            // 
            this.sortByProductIDToolStripMenuItem.Name = "sortByProductIDToolStripMenuItem";
            this.sortByProductIDToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sortByProductIDToolStripMenuItem.Text = "Sort By Product ID";
            this.sortByProductIDToolStripMenuItem.Click += new System.EventHandler(this.SortByProductIDToolStripMenuItem_Click);
            // 
            // sortByProductPriceToolStripMenuItem
            // 
            this.sortByProductPriceToolStripMenuItem.Name = "sortByProductPriceToolStripMenuItem";
            this.sortByProductPriceToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sortByProductPriceToolStripMenuItem.Text = "Sort By Product Price";
            this.sortByProductPriceToolStripMenuItem.Click += new System.EventHandler(this.SortByProductPriceToolStripMenuItem_Click);
            // 
            // sortByProductCostToolStripMenuItem
            // 
            this.sortByProductCostToolStripMenuItem.Name = "sortByProductCostToolStripMenuItem";
            this.sortByProductCostToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sortByProductCostToolStripMenuItem.Text = "Sort By Product Cost";
            this.sortByProductCostToolStripMenuItem.Click += new System.EventHandler(this.SortByProductCostToolStripMenuItem_Click);
            // 
            // toolStripSearchTextBox
            // 
            this.toolStripSearchTextBox.Name = "toolStripSearchTextBox";
            this.toolStripSearchTextBox.Size = new System.Drawing.Size(100, 25);
            this.toolStripSearchTextBox.ToolTipText = "Search";
            // 
            // toolStripSearchButton
            // 
            this.toolStripSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchButton.Image")));
            this.toolStripSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearchButton.Name = "toolStripSearchButton";
            this.toolStripSearchButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSearchButton.Text = "Search";
            this.toolStripSearchButton.Click += new System.EventHandler(this.ToolStripSearchButton_Click);
            // 
            // toolStripFilterButton
            // 
            this.toolStripFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFilterButton.Image")));
            this.toolStripFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFilterButton.Name = "toolStripFilterButton";
            this.toolStripFilterButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripFilterButton.Text = "toolStripButton1";
            this.toolStripFilterButton.ToolTipText = "Filter by product name";
            this.toolStripFilterButton.Click += new System.EventHandler(this.ToolStripFilterButton_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(157, 66);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(121, 23);
            this.productIDTextBox.TabIndex = 3;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductName", true));
            this.productNameComboBox.DataSource = this.pRODUCTBindingSource;
            this.productNameComboBox.DisplayMember = "ProductName";
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(157, 95);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.productNameComboBox.TabIndex = 5;
            // 
            // vendorIDComboBox
            // 
            this.vendorIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "VendorID", true));
            this.vendorIDComboBox.DataSource = this.vENDORBindingSource;
            this.vendorIDComboBox.DisplayMember = "VendorID";
            this.vendorIDComboBox.FormattingEnabled = true;
            this.vendorIDComboBox.Location = new System.Drawing.Point(157, 124);
            this.vendorIDComboBox.Name = "vendorIDComboBox";
            this.vendorIDComboBox.Size = new System.Drawing.Size(121, 23);
            this.vendorIDComboBox.TabIndex = 7;
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.productDatabaseDataSet;
            // 
            // productUnitPriceTextBox
            // 
            this.productUnitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductUnitPrice", true));
            this.productUnitPriceTextBox.Location = new System.Drawing.Point(157, 153);
            this.productUnitPriceTextBox.Name = "productUnitPriceTextBox";
            this.productUnitPriceTextBox.Size = new System.Drawing.Size(121, 23);
            this.productUnitPriceTextBox.TabIndex = 9;
            // 
            // product_CostTextBox
            // 
            this.product_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Product Cost", true));
            this.product_CostTextBox.Location = new System.Drawing.Point(157, 182);
            this.product_CostTextBox.Name = "product_CostTextBox";
            this.product_CostTextBox.Size = new System.Drawing.Size(121, 23);
            this.product_CostTextBox.TabIndex = 11;
            // 
            // quantity_On_HandTextBox
            // 
            this.quantity_On_HandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Quantity-On-Hand", true));
            this.quantity_On_HandTextBox.Location = new System.Drawing.Point(157, 211);
            this.quantity_On_HandTextBox.Name = "quantity_On_HandTextBox";
            this.quantity_On_HandTextBox.Size = new System.Drawing.Size(121, 23);
            this.quantity_On_HandTextBox.TabIndex = 13;
            // 
            // quantity_On_OrderTextBox
            // 
            this.quantity_On_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Quantity-On-Order", true));
            this.quantity_On_OrderTextBox.Location = new System.Drawing.Point(157, 240);
            this.quantity_On_OrderTextBox.Name = "quantity_On_OrderTextBox";
            this.quantity_On_OrderTextBox.Size = new System.Drawing.Size(121, 23);
            this.quantity_On_OrderTextBox.TabIndex = 15;
            // 
            // product_Lead_TimeTextBox
            // 
            this.product_Lead_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Product Lead-Time", true));
            this.product_Lead_TimeTextBox.Location = new System.Drawing.Point(157, 269);
            this.product_Lead_TimeTextBox.Name = "product_Lead_TimeTextBox";
            this.product_Lead_TimeTextBox.Size = new System.Drawing.Size(121, 23);
            this.product_Lead_TimeTextBox.TabIndex = 17;
            // 
            // productReorderLevelTextBox
            // 
            this.productReorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductReorderLevel", true));
            this.productReorderLevelTextBox.Location = new System.Drawing.Point(157, 298);
            this.productReorderLevelTextBox.Name = "productReorderLevelTextBox";
            this.productReorderLevelTextBox.Size = new System.Drawing.Size(121, 23);
            this.productReorderLevelTextBox.TabIndex = 19;
            // 
            // productLineTextBox
            // 
            this.productLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductLine", true));
            this.productLineTextBox.Location = new System.Drawing.Point(157, 327);
            this.productLineTextBox.Name = "productLineTextBox";
            this.productLineTextBox.Size = new System.Drawing.Size(121, 23);
            this.productLineTextBox.TabIndex = 21;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(157, 356);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(121, 23);
            this.brandTextBox.TabIndex = 23;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(157, 385);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(121, 23);
            this.discountTextBox.TabIndex = 25;
            // 
            // yTDPurchasesTextBox
            // 
            this.yTDPurchasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "YTDPurchases", true));
            this.yTDPurchasesTextBox.Location = new System.Drawing.Point(157, 414);
            this.yTDPurchasesTextBox.Name = "yTDPurchasesTextBox";
            this.yTDPurchasesTextBox.Size = new System.Drawing.Size(121, 23);
            this.yTDPurchasesTextBox.TabIndex = 27;
            // 
            // yTDSalesTextBox
            // 
            this.yTDSalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "YTDSales", true));
            this.yTDSalesTextBox.Location = new System.Drawing.Point(157, 443);
            this.yTDSalesTextBox.Name = "yTDSalesTextBox";
            this.yTDSalesTextBox.Size = new System.Drawing.Size(121, 23);
            this.yTDSalesTextBox.TabIndex = 29;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(444, 66);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.ReadOnly = true;
            this.vendorNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.vendorNameTextBox.TabIndex = 31;
            // 
            // vendorRegionTextBox
            // 
            this.vendorRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "VendorRegion", true));
            this.vendorRegionTextBox.Location = new System.Drawing.Point(444, 95);
            this.vendorRegionTextBox.Name = "vendorRegionTextBox";
            this.vendorRegionTextBox.ReadOnly = true;
            this.vendorRegionTextBox.Size = new System.Drawing.Size(100, 23);
            this.vendorRegionTextBox.TabIndex = 33;
            // 
            // state_ProvinceTextBox
            // 
            this.state_ProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "State/Province", true));
            this.state_ProvinceTextBox.Location = new System.Drawing.Point(444, 124);
            this.state_ProvinceTextBox.Name = "state_ProvinceTextBox";
            this.state_ProvinceTextBox.ReadOnly = true;
            this.state_ProvinceTextBox.Size = new System.Drawing.Size(100, 23);
            this.state_ProvinceTextBox.TabIndex = 35;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(444, 153);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(100, 23);
            this.cityTextBox.TabIndex = 37;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(444, 182);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.ReadOnly = true;
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.postalCodeTextBox.TabIndex = 39;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(444, 211);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(100, 23);
            this.countryTextBox.TabIndex = 41;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(444, 240);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.ReadOnly = true;
            this.emailAddressTextBox.Size = new System.Drawing.Size(100, 23);
            this.emailAddressTextBox.TabIndex = 43;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(444, 269);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.phoneNumberTextBox.TabIndex = 45;
            // 
            // websiteAddressTextBox
            // 
            this.websiteAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "WebsiteAddress", true));
            this.websiteAddressTextBox.Location = new System.Drawing.Point(444, 298);
            this.websiteAddressTextBox.Name = "websiteAddressTextBox";
            this.websiteAddressTextBox.ReadOnly = true;
            this.websiteAddressTextBox.Size = new System.Drawing.Size(100, 23);
            this.websiteAddressTextBox.TabIndex = 47;
            // 
            // classificationTextBox
            // 
            this.classificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Classification", true));
            this.classificationTextBox.Location = new System.Drawing.Point(444, 327);
            this.classificationTextBox.Name = "classificationTextBox";
            this.classificationTextBox.ReadOnly = true;
            this.classificationTextBox.Size = new System.Drawing.Size(100, 23);
            this.classificationTextBox.TabIndex = 49;
            // 
            // activeStatusTextBox
            // 
            this.activeStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "ActiveStatus", true));
            this.activeStatusTextBox.Location = new System.Drawing.Point(444, 356);
            this.activeStatusTextBox.Name = "activeStatusTextBox";
            this.activeStatusTextBox.ReadOnly = true;
            this.activeStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.activeStatusTextBox.TabIndex = 51;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(444, 385);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(100, 23);
            this.notesTextBox.TabIndex = 53;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(444, 414);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.ReadOnly = true;
            this.contactNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactNameTextBox.TabIndex = 55;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Major_Project_3.ProductDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = this.vENDORTableAdapter;
            // 
            // vENDORTableAdapter
            // 
            this.vENDORTableAdapter.ClearBeforeFill = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductName", true));
            this.filterComboBox.DataSource = this.pRODUCTBindingSource;
            this.filterComboBox.DisplayMember = "ProductName";
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(524, 24);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 23);
            this.filterComboBox.TabIndex = 64;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorRegionLabel);
            this.Controls.Add(this.vendorRegionTextBox);
            this.Controls.Add(state_ProvinceLabel);
            this.Controls.Add(this.state_ProvinceTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(websiteAddressLabel);
            this.Controls.Add(this.websiteAddressTextBox);
            this.Controls.Add(classificationLabel);
            this.Controls.Add(this.classificationTextBox);
            this.Controls.Add(activeStatusLabel);
            this.Controls.Add(this.activeStatusTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(contactNameLabel);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDComboBox);
            this.Controls.Add(productUnitPriceLabel);
            this.Controls.Add(this.productUnitPriceTextBox);
            this.Controls.Add(product_CostLabel);
            this.Controls.Add(this.product_CostTextBox);
            this.Controls.Add(quantity_On_HandLabel);
            this.Controls.Add(this.quantity_On_HandTextBox);
            this.Controls.Add(quantity_On_OrderLabel);
            this.Controls.Add(this.quantity_On_OrderTextBox);
            this.Controls.Add(product_Lead_TimeLabel);
            this.Controls.Add(this.product_Lead_TimeTextBox);
            this.Controls.Add(productReorderLevelLabel);
            this.Controls.Add(this.productReorderLevelTextBox);
            this.Controls.Add(productLineLabel);
            this.Controls.Add(this.productLineTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(yTDPurchasesLabel);
            this.Controls.Add(this.yTDPurchasesTextBox);
            this.Controls.Add(yTDSalesLabel);
            this.Controls.Add(this.yTDSalesTextBox);
            this.Controls.Add(this.pRODUCTBindingNavigator);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YTDAveragePurchaseLabel);
            this.Controls.Add(this.YTDTotalPurchaseLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vendor and Product Database App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).EndInit();
            this.pRODUCTBindingNavigator.ResumeLayout(false);
            this.pRODUCTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductDatabaseDataSet productDatabaseDataSet;
        private ProductDatabaseDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private ProductDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProductDatabaseDataSetTableAdapters.VENDORTableAdapter vENDORTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label YTDTotalPurchaseLabel;
        private System.Windows.Forms.Label YTDAveragePurchaseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.BindingNavigator pRODUCTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ComboBox vendorIDComboBox;
        private System.Windows.Forms.TextBox productUnitPriceTextBox;
        private System.Windows.Forms.TextBox product_CostTextBox;
        private System.Windows.Forms.TextBox quantity_On_HandTextBox;
        private System.Windows.Forms.TextBox quantity_On_OrderTextBox;
        private System.Windows.Forms.TextBox product_Lead_TimeTextBox;
        private System.Windows.Forms.TextBox productReorderLevelTextBox;
        private System.Windows.Forms.TextBox productLineTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox yTDPurchasesTextBox;
        private System.Windows.Forms.TextBox yTDSalesTextBox;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorRegionTextBox;
        private System.Windows.Forms.TextBox state_ProvinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox websiteAddressTextBox;
        private System.Windows.Forms.TextBox classificationTextBox;
        private System.Windows.Forms.TextBox activeStatusTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTextBox;
        private System.Windows.Forms.ToolStripButton toolStripSearchButton;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInUSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInChinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInNewYorkToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripButton toolStripFilterButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSortByDropDown;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByProductIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByProductPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByProductCostToolStripMenuItem;
    }
}

