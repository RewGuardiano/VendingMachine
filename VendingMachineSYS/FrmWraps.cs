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
    public partial class FrmWraps : Form
    {
        private FrmOrderScreen frmOrderScreen;
        public FrmWraps(FrmOrderScreen frmOrderScreen)
        {
            this.frmOrderScreen = frmOrderScreen;
            InitializeComponent();
        }

        private void FrmWraps_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOrderScreen.Show();
        }

        private void btnBackDrink_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderScreen.Show();
        }

        private void btn_grilled_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Grilled").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_crispy_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Crispy").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_salad_chicken_wrap_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Salad Chicken Wrap").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }
    }
}
