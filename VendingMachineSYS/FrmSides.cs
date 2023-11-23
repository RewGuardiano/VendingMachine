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
    public partial class FrmSides : Form
    {
        private FrmOrderScreen frmOrderScreen;
        public FrmSides(FrmOrderScreen frmOrderScreen)
        {
            this.frmOrderScreen = frmOrderScreen;
            InitializeComponent();
        }

        private void FrmSides_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOrderScreen.Show();
        }

        private void btnBackDesserts_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderScreen.Show();
        }

        private void btn_fries_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Fries").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }

        private void btn_nugets_Click(object sender, EventArgs e)
        {
            int orderNumber = frmOrderScreen.GetOrderCount();
            Order order = new Order(-1, orderNumber, MenuItem.FindMenuItemByName("Nugets").GetMenuItemId());
            order.AddOrder();
            frmOrderScreen.AddOrderNumber(orderNumber);
        }
    }
}
