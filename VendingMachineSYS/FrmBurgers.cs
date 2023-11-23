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
    public partial class FrmBurgers : Form
    {
        public FrmOrderScreen frmOrderScreen;
        public FrmBurgers(FrmOrderScreen frmOrderScreen)
        {
            this.frmOrderScreen = frmOrderScreen;
            InitializeComponent();
        }

        private void back_onClick(object sender, EventArgs e)
        {
            Close();
            frmOrderScreen.Show();
        }

        private void FrmBurgers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOrderScreen.Show();
        }

        private void btn_chicken_and_salad_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Chicken and Salad").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_ham_and_sweetcorn_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Ham and Sweetcorn").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_ham_and_beef_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Ham and Beef").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }
    }
}
