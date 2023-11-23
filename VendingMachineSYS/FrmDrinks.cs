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
    public partial class FrmDrinks : Form
    {
        private FrmOrderScreen frmOrderScreen;
        public FrmDrinks(FrmOrderScreen frmOrderScreen)
        {
            this.frmOrderScreen = frmOrderScreen;
            InitializeComponent();
        }

        private void FrmDrinks_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOrderScreen.Show();
        }

        private void btnBackDrink_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderScreen.Show();
        }

        private void btn_coca_cola_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Coca Cola").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_fanta_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Fanta").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_sevenUp_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("7Up").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }
    }
}
