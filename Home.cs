using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lomitdajo
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelProductsSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelProductsSubmenu.Visible == true)
            {
                panelProductsSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductsSubmenu);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openContainer(new dashboard());
            hideSubMenu();
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            openContainer(new purchaseorders());
            hideSubMenu();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            openContainer(new managecategories());
            hideSubMenu();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            openContainer(new managesuppliers());
            hideSubMenu();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            openContainer(new manageusers());
            hideSubMenu();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            openContainer(new salesreport());
            hideSubMenu();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            openContainer(new inventoryreport());
            hideSubMenu();
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            openContainer(new searchproducts());
            hideSubMenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            openContainer(new instock());
            hideSubMenu();
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            openContainer(new allproducts());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openContainer(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
