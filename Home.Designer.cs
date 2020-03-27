namespace lomitdajo
{
    partial class Home
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelProductsSubmenu = new System.Windows.Forms.Panel();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnInStock = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnManageSuppliers = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelProductsSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelSideMenu.Controls.Add(this.btnInventoryReport);
            this.panelSideMenu.Controls.Add(this.btnSalesReport);
            this.panelSideMenu.Controls.Add(this.btnManageUsers);
            this.panelSideMenu.Controls.Add(this.btnManageSuppliers);
            this.panelSideMenu.Controls.Add(this.btnManageCategories);
            this.panelSideMenu.Controls.Add(this.btnPurchaseOrders);
            this.panelSideMenu.Controls.Add(this.panelProductsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnProducts);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(165, 513);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(0, 85);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(165, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Location = new System.Drawing.Point(0, 130);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(165, 45);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelProductsSubmenu
            // 
            this.panelProductsSubmenu.Controls.Add(this.btnAllProducts);
            this.panelProductsSubmenu.Controls.Add(this.btnInStock);
            this.panelProductsSubmenu.Controls.Add(this.btnSearchProducts);
            this.panelProductsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductsSubmenu.Location = new System.Drawing.Point(0, 175);
            this.panelProductsSubmenu.Name = "panelProductsSubmenu";
            this.panelProductsSubmenu.Size = new System.Drawing.Size(165, 96);
            this.panelProductsSubmenu.TabIndex = 3;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProducts.Location = new System.Drawing.Point(0, 0);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchProducts.Size = new System.Drawing.Size(165, 30);
            this.btnSearchProducts.TabIndex = 0;
            this.btnSearchProducts.Text = "Search Products";
            this.btnSearchProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // btnInStock
            // 
            this.btnInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInStock.Location = new System.Drawing.Point(0, 30);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInStock.Size = new System.Drawing.Size(165, 32);
            this.btnInStock.TabIndex = 1;
            this.btnInStock.Text = "In Stock";
            this.btnInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInStock.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrders.Location = new System.Drawing.Point(0, 271);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPurchaseOrders.Size = new System.Drawing.Size(165, 40);
            this.btnPurchaseOrders.TabIndex = 4;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCategories.FlatAppearance.BorderSize = 0;
            this.btnManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategories.Location = new System.Drawing.Point(0, 311);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCategories.Size = new System.Drawing.Size(165, 40);
            this.btnManageCategories.TabIndex = 5;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategories.UseVisualStyleBackColor = true;
            // 
            // btnManageSuppliers
            // 
            this.btnManageSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSuppliers.FlatAppearance.BorderSize = 0;
            this.btnManageSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSuppliers.Location = new System.Drawing.Point(0, 351);
            this.btnManageSuppliers.Name = "btnManageSuppliers";
            this.btnManageSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageSuppliers.Size = new System.Drawing.Size(165, 40);
            this.btnManageSuppliers.TabIndex = 6;
            this.btnManageSuppliers.Text = "Manage Suppliers";
            this.btnManageSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 391);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageUsers.Size = new System.Drawing.Size(165, 40);
            this.btnManageUsers.TabIndex = 7;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 431);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesReport.Size = new System.Drawing.Size(165, 40);
            this.btnSalesReport.TabIndex = 8;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryReport.FlatAppearance.BorderSize = 0;
            this.btnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryReport.Location = new System.Drawing.Point(0, 471);
            this.btnInventoryReport.Name = "btnInventoryReport";
            this.btnInventoryReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventoryReport.Size = new System.Drawing.Size(165, 36);
            this.btnInventoryReport.TabIndex = 9;
            this.btnInventoryReport.Text = "Inventory Report";
            this.btnInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryReport.UseVisualStyleBackColor = true;
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Location = new System.Drawing.Point(0, 62);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAllProducts.Size = new System.Drawing.Size(165, 32);
            this.btnAllProducts.TabIndex = 2;
            this.btnAllProducts.Text = "All Products";
            this.btnAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProducts.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 513);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(890, 520);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelProductsSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelProductsSubmenu;
        private System.Windows.Forms.Button btnInStock;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageSuppliers;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnAllProducts;
    }
}

