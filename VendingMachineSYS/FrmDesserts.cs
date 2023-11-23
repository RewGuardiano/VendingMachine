using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSYS
{
    public partial class FrmDesserts : Form
    {
        private FrmOrderScreen frmOrderScreen;
        public FrmDesserts(FrmOrderScreen frmOrderScreen)
        {
            this.frmOrderScreen = frmOrderScreen;
            InitializeComponent();
        }

        private void FrmBurgers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOrderScreen.Show();
        }

        private void btnBackDesserts_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderScreen.Show();
        }

        private void btn_ice_cream_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Ice Cream").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_apple_pie_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Apple Pie").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_donuts_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Donuts").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }
    }
}
