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
using Windows.UI.Xaml.Media.Imaging;

namespace CustomerApp
{
    public sealed partial class pgDragon : Page
    {
        private delegate void LoadDragonControlDelegate(clsAllDragons prDragon);
        private Dictionary<char, Delegate> _DragonContent;
        private void dispatchDragonContent(clsAllDragons prDragon)
        {
            Char lcSpecies = prDragon.getChar();
            _DragonContent[lcSpecies].DynamicInvoke(prDragon);
            UpdatePage(prDragon);
        }

        private clsAllDragons _Dragon;
        private clsAllOrders _Order = new clsAllOrders();

        public pgDragon()
        {
            this.InitializeComponent();
            _DragonContent = new Dictionary<char, Delegate>
            {
                { 'W', new LoadDragonControlDelegate(RunWestern) },
                { 'L', new LoadDragonControlDelegate(RunLung) },
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            dispatchDragonContent(e.Parameter as clsAllDragons); // ?
        }

        private void UpdatePage(clsAllDragons prDragon)
        {
            _Dragon = prDragon;
            txtbTitle.Text = "Dragon Profile: " + _Dragon.Name + "(" + Convert.ToString(_Dragon.DragonID) + ")";

            try
            {
                txtbID.Text = Convert.ToString(_Dragon.DragonID);
                txtbName.Text = _Dragon.Name;
                txtbSpecies.Text = _Dragon.Species;
                txtbBreed.Text = _Dragon.Breed;
                txtbAge.Text = Convert.ToString(_Dragon.Age);
                txtbSex.Text = _Dragon.Sex;
                txtbSize.Text = Convert.ToString(_Dragon.Size);
                txtbTame.Text = _Dragon.Tame;
                txtbPrice.Text = Convert.ToString(_Dragon.Price);
                txtbAvailable.Text = _Dragon.Available;
                (ctcDragonSpecs.Content as IDragonControl).UpdateControl(prDragon);
                CheckAvailability();
            }
            catch
            {
                txtbTitle.Text = "Data retrival error";
            }

            GetImage();
        }

        private void GetImage()
        {
            try
            {
                imgDragon.Source = new BitmapImage(
                new Uri(_Dragon.Image, UriKind.Absolute));
            }
            catch
            {
                imgDragon.Source = new BitmapImage(
                new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/240px-No_image_available.svg.png", UriKind.Absolute));
                imgDragon.Stretch = Stretch.Fill;
            }
        }

        private void CheckAvailability()
        {
            if (_Dragon.Available == "N")
            {
                btnPurchase.IsEnabled = false;
                btnPurchase.Content = "Unavailable";
            }
        }

        private void RunWestern(clsAllDragons prDragon)
        {
            ctcDragonSpecs.Content = new ucDragonWestern();
        }
        private void RunLung(clsAllDragons prDragon)
        {
            ctcDragonSpecs.Content = new ucDragonLung();
        }

        private async void PurchaseDragon()
        {
            if (isValid() == true && _Dragon.Available == "Y")
            {
                PushData();
                txtbTitle.Text = (await ServiceClient.UpdateOrderDragonAsync(_Dragon));
                if (txtbTitle.Text == "\"One Dragon order updated\"")
                {
                    txtbTitle.Text = (await ServiceClient.InsertOrderAsync(_Order));
                    ChangeAvailability();
                }
                else
                {
                    btnPurchase.Content = "Purchase Error: Return to List";
                }
            }
            else
            {
                CheckAvailability();
            }
        }

        private bool isValid()
        {
            if (txtCustomerName.Text == "" || txtCustomerName.Text == "Enter Name")
            {
                txtbTitle.Text = "Input name to buy";
                return false;
            }
            return true;
        }

        private void PushData() 
        {
            _Order.DragonID = Convert.ToInt16(txtbID.Text);
            _Order.CurrentPrice = Convert.ToInt16(txtbPrice.Text);
            _Order.DateOrdered = DateTime.Now;
            _Order.CustomerName = txtCustomerName.Text;
            _Dragon.Available = "N";
        }
        private void ChangeAvailability()
        {
            btnPurchase.IsEnabled = false;
            btnPurchase.Content = "Success!";
            txtbAvailable.Text = _Dragon.Available;
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnPurchase.Content == "Purchase")
            {
                PurchaseDragon();
            }
            else
            {
                Frame.GoBack();
            }
            
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
