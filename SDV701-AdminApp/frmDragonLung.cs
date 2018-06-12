using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV701_AdminApp
{
    public sealed partial class frmDragonLung : SDV701_AdminApp.frmDragon
    {
        private static readonly frmDragonLung instance = new frmDragonLung();
        private static string[] _flightSource = { "Y", "N" };

        public frmDragonLung()
        {
            InitializeComponent();
        }

        internal static void Run(clsAllDragons prDragon)
        {
            instance.cmbFlight.DataSource = _flightSource;
            instance.SetDetails(prDragon);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtLength.Text = _Dragon.Length.ToString();
            txtWhiskers.Text = _Dragon.Whiskers.ToString();
            cmbFlight.SelectedItem = _Dragon.Flight;
        }

        protected override void pushData()
        {
            base.pushData();
            _Dragon.Length = Convert.ToInt16(txtLength.Text);
            _Dragon.Whiskers = Convert.ToInt16(txtWhiskers.Text);
            _Dragon.Flight = cmbFlight.SelectedItem.ToString();
        }
    }
}
