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
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();
        }

        private async void pgMainPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstBreeds.ItemsSource = await ServiceClient.GetBreedNamesAsync();
            }
            catch
            {
                txtbMessages.Text = "Error: List load failure, check server connection";
            }
        }

        private void btnViewDragons_Click(object sender, RoutedEventArgs e)
        {
            SelectBreed();
        }
        private void lstBreeds_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            SelectBreed();
        }
        private void SelectBreed()
        {
            if (lstBreeds.SelectedItem != null)
                Frame.Navigate(typeof(pgBreed), lstBreeds.SelectedItem);
        }
    }
}
