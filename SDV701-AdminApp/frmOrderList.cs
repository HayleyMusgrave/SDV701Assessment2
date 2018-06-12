using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701_AdminApp
{
    public sealed partial class frmOrderList : Form
    {
        private static readonly frmOrderList _instance = new frmOrderList();
        private frmOrderList()
        {
            InitializeComponent();
        }
        public static frmOrderList Instance
        {
            get { return _instance; }
        }

        public void Run()
        {
            Instance.UpdateDisplay();
        }

        private async void UpdateDisplay()
        {
            try
            {
                lstOrderList.DataSource = null;
                lstOrderList.DataSource = await ServiceClient.GetAllOrdersAsync();

                
                lblSaleValue.Text = Convert.ToString(await ServiceClient.GetSalesTotalAsync());
                Show();
            }
            catch
            {
                MessageBox.Show("List retrieval error", "Error");
            }
        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lstOrderList.SelectedItem == null)
            {
                MessageBox.Show("No order was selected. If list is empty, check server connection.", "No Selection Made");
            }
            else
            {
                clsAllOrders lcSelected = lstOrderList.SelectedValue as clsAllOrders;
                if (MessageBox.Show("Are you sure?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(await ServiceClient.DeleteOrderAsync(lcSelected));
                    UpdateDisplay();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
