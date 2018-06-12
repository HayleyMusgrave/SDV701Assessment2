using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV701_AdminApp
{
    public partial class frmDragonWestern : SDV701_AdminApp.frmDragon
    {
        private static readonly frmDragonWestern instance = new frmDragonWestern();
        private static string[] _stanceSource = { "Quadrapedal", "Bipedal" };
        private static string[] _fireSource = { "Y", "N" };
        private static string[] _poisonSource = { "Y", "N" };

        private frmDragonWestern()
        {
            InitializeComponent();
        }

        public static void Run(clsAllDragons prDragon)
        {
            instance.cmbStance.DataSource = _stanceSource;
            instance.cmbFire.DataSource = _fireSource;
            instance.cmbPoison.DataSource = _poisonSource;

            instance.SetDetails(prDragon);
        }

        protected override void updateForm()
        {
            base.updateForm();
            cmbStance.SelectedItem = _Dragon.Stance;
            cmbFire.SelectedItem = _Dragon.Fire;
            cmbPoison.SelectedItem = _Dragon.Poison;
        }

        protected override void pushData()
        {
            base.pushData();
            _Dragon.Stance = cmbStance.Text;
            _Dragon.Fire = cmbFire.Text;
            _Dragon.Poison = cmbPoison.Text;
        }
    }
}
