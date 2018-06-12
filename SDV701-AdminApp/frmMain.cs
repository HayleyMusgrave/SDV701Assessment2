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
    public sealed partial class frmMain : Form
    {
        private static readonly frmMain _instance = new frmMain();
        
        private frmMain()
        {
            InitializeComponent();
        }
        public static frmMain Instance
        {
            get { return frmMain._instance; }
        }

        public async void UpdatDisplay()
        {
            try
            {
                lstBreeds.DataSource = null;
                lstBreeds.DataSource = await ServiceClient.GetBreedNamesAsync();
            }
            catch
            {
                MessageBox.Show("List retrieval error, check data connection", "Error");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdatDisplay();
        }

        private void btnViewDragons_Click(object sender, EventArgs e)
        {
            SelectBreed();
        }
        private void lstBreeds_DoubleClick(object sender, EventArgs e)
        {
            SelectBreed();
        }

        private void SelectBreed()
        {
            if (lstBreeds.SelectedItem == null)
            {
                MessageBox.Show("No breed is selected. If list is empty, check server connection.", "No Selection Made");
            }
            else
            {
                frmBreed.Run(lstBreeds.SelectedItem as string);
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrderList.Instance.Run();
        }

        private void btnSaveQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
