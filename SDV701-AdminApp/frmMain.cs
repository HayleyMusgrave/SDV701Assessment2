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
            get { return _instance; }
        }
    }
}
