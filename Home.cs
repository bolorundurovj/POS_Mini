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
    public partial class Home : Form
    {
        public Home()
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
    }
}
