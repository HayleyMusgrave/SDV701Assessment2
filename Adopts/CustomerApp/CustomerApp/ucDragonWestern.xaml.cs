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
    public sealed partial class ucDragonWestern : UserControl, IDragonControl
    {
        public ucDragonWestern()
        {
            this.InitializeComponent();
        }

        public void PushData(clsAllDragons prDragon)
        {
        }

        public void UpdateControl(clsAllDragons prDragon)
        {
            txtbStance.Text = prDragon.Stance;
            txtbFire.Text = prDragon.Fire;
            txtbPoison.Text = prDragon.Poison;
        }
    }
}
