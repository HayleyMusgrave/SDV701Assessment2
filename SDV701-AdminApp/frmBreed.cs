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
    public sealed partial class frmBreed : Form 
    {
        private static readonly frmBreed instance = new frmBreed();
        private clsBreed _Breed;
        private static string[] _speciesType = { "Western", "Lung" };
        private static string[] _sortOrderList = { "ID",  "Name", "Age", "Price" };

        public static frmBreed Instance
        {
            get { return frmBreed.instance; }
        }

        private frmBreed()
        {
            InitializeComponent();
        }

        public static void Run(string prBreedName)
        {
            instance.refreshFormFromDB(prBreedName);
        }

        private async void refreshFormFromDB(string prBreedName)
        {
            SetDetails(await ServiceClient.GetBreedAsync(prBreedName));
        }

        private void GetSortOrder()
        {
            if ((string)cmbSortOrder.SelectedItem == "Name")
            {
                _Breed.DragonList.Sort(clsNameComparer.Instance);
            }
            else if ((string)cmbSortOrder.SelectedItem == "Age")
            {
                _Breed.DragonList.Sort(clsAgeComparer.Instance);
            }
            else if ((string)cmbSortOrder.SelectedItem == "Price")
            {
                _Breed.DragonList.Sort(clsPriceComparer.Instance);
            }
            else
            {
                _Breed.DragonList.Sort(clsIDComparer.Instance);
            }
        }

        public void SetDetails(clsBreed prBreed) 
        {
            _Breed = prBreed;
            UpdateForm();
            Show();
        }

        public void UpdateForm()
        {
            try
            {
                cmbSortOrder.DataSource = _sortOrderList;
                cmbDragonType.DataSource = _speciesType;
                GetSortOrder();

                lblBreedName.Text = "Name: " + _Breed.BreedName;
                lblBreedRarity.Text = "Rarity: " + _Breed.Rarity;
                lblBreedCost.Text = "Base Cost: " + _Breed.BaseCost;
                lblBreedOrigin.Text = "Origin: " + _Breed.Origin;
                lblBreedNameList.Text = _Breed.BreedName + " Dragons";

                UpdateList();
            }
            catch
            {
                MessageBox.Show("Something went wrong with displaying the list.", "List Display Error");
            }
        }
        public void UpdateList()
        {
            lstDragons.DataSource = null;
            if (_Breed.DragonList != null)
                lstDragons.DataSource = _Breed.DragonList;
        }

        private void btnAddDragon_Click(object sender, EventArgs e)
        {
            string lcChoice = Convert.ToString(cmbDragonType.SelectedItem);
            clsAllDragons lcDragon = clsAllDragons.NewDragon(lcChoice, _Breed.BreedName, DateTime.Now);
            if (lcDragon != null)
            {
                frmDragon.DispatchDragonForm(lcDragon);
                if (!string.IsNullOrEmpty(lcDragon.Name))
                {
                    refreshFormFromDB(_Breed.BreedName);
                }
            }
            UpdateList();
        }

        private void btnEditDragon_Click(object sender, EventArgs e)
        {
            SelectDragon();
        }
        private void lstDragons_DoubleClick(object sender, EventArgs e)
        {
            SelectDragon();
        }

        private void SelectDragon()
        {
            frmDragon.DispatchDragonForm(lstDragons.SelectedValue as clsAllDragons);
            UpdateList();
        }

        private async void btnRemoveDragon_Click(object sender, EventArgs e)
        {
            clsAllDragons lcSelected = lstDragons.SelectedValue as clsAllDragons;

            if (lcSelected != null && MessageBox.Show("Are you sure? Deleting dragon may affect pending orders.", "Delete Dragon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteDragonAsync(lcSelected));
                refreshFormFromDB(_Breed.BreedName);
                UpdateList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSortOrder();
            UpdateList();
        }
    }
}
