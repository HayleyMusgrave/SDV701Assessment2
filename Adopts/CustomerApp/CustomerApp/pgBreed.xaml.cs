using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CustomerApp
{
    public sealed partial class pgBreed : Page
    {
        private clsBreed _Breed;

        public pgBreed()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                base.OnNavigatedTo(e);
                if (e.Parameter != null)
                {
                    string lcBreedName = e.Parameter.ToString();
                    _Breed = await ServiceClient.GetBreedAsync(lcBreedName);
                    UpdateForm();
                }
            }
            catch
            {
                txtbMessages.Text = "Navigation error";
            }
            
        }

        private void UpdateForm()
        {
            try
            {
                txtbTitle.Text = "Current " + _Breed.BreedName + " Dragons Available";
            txtbBreedInfo.Text = "Rarity: " + _Breed.Rarity + "\t Origin: " + _Breed.Origin + "\n Base Price: " + _Breed.BaseCost;
            txtbListLabels.Text = "ID \t Name \t Species  \t Age \t Sex \t Size \t Price \t Tame \t Available \t  Edit Date";

            UpdateList();
            }
            catch
            {
                txtbMessages.Text = "Form display error";
            }
        }

        private void UpdateList()
        {
            lstDragons.ItemsSource = null;
            if (_Breed.DragonList != null)
                lstDragons.ItemsSource = _Breed.DragonList;
        }

        private void btnViewDragons_Click(object sender, RoutedEventArgs e)
        {
            SelectDragon();
        }
        private void lstDragons_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            SelectDragon();
        }
        private void SelectDragon()
        {
            if (lstDragons.SelectedItem != null)
                Frame.Navigate(typeof(pgDragon), lstDragons.SelectedItem as clsAllDragons);
            UpdateList();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
