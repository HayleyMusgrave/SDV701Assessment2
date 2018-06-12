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
    public sealed partial class ucDragonLung : UserControl, IDragonControl
    {
        public ucDragonLung()
        {
            this.InitializeComponent();
        }

        public void PushData(clsAllDragons prDragon)
        {
        }

        public void UpdateControl(clsAllDragons prDragon)
        {
            txtbLength.Text = Convert.ToString(prDragon.Length);
            txtbWhiskers.Text = Convert.ToString(prDragon.Whiskers);
            txtbFlight.Text = prDragon.Flight;
        }
    }
}
