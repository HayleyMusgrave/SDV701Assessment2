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
    public partial class frmDragon : Form
    {
        public delegate void LoadWorkFormDelegte(clsAllDragons prDragonID);
        public static Dictionary<char, Delegate> _DragonForm = new Dictionary<char, Delegate>
        {
            {'W', new LoadWorkFormDelegte(frmDragonWestern.Run) },
            {'L', new LoadWorkFormDelegte(frmDragonLung.Run) }
        };
        public static void DispatchDragonForm(clsAllDragons prDragon)
        {
            char lcSpecies = prDragon.getChar();
            _DragonForm[lcSpecies].DynamicInvoke(prDragon);
        }

        protected clsAllDragons _Dragon;
        private static string[] _sexSource = { "F", "M" };
        protected static string[] _tameSource = { "Y", "N" };
        protected static string[] _availableSource = { "Y", "N" };
        private static string[] _imageNameSource = { "https://tinyurl.com/yblolh8t", "https://tinyurl.com/y7zr764u", "https://tinyurl.com/y7uevgv2", "https://tinyurl.com/y8b8a8wm", "https://tinyurl.com/yaqw2n33", "https://tinyurl.com/y97rxcok" };

        public frmDragon()
        {
            InitializeComponent();
        }

        public void SetDetails(clsAllDragons prDragon)
        {
            _Dragon = prDragon;
            cmbTame.DataSource = _tameSource;
            cmbAvailable.DataSource = _availableSource;
            cmbSex.DataSource = _sexSource;
            cmbImage.DataSource = _imageNameSource;
            
            updateForm();
            ShowDialog();
        }

        protected virtual bool isValid()
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtPrice.Text == "" || txtSize.Text == "")
            {
                MessageBox.Show("Data Entry Error: Make sure all textboxes have a value in it", "Invalid Data");
                return false;
            }
            if (cmbSex.Text == "" || cmbTame.Text == "" || cmbAvailable.Text == "")
            {
                MessageBox.Show("Data Entry Error: Make sure all comboboxes/dropdowns have a selection made", "Invalid Data");
                return false;
            }
            return true;
        }

        protected virtual void updateForm()
        {
            clsAllDragons lcDragon = (clsAllDragons)_Dragon;

            lblDate.Text = _Dragon.DateEdited.ToString();
            lblIDNumber.Text = _Dragon.DragonID.ToString();
            txtName.Text = _Dragon.Name;
            txtAge.Text = _Dragon.Age.ToString();
            cmbSex.SelectedItem = _Dragon.Sex; 
            txtSize.Text = _Dragon.Size.ToString();
            txtPrice.Text = _Dragon.Price.ToString();
            cmbTame.SelectedItem = _Dragon.Tame;
            cmbAvailable.SelectedItem = _Dragon.Available;

            cmbImage.SelectedIndex = -1; // Temp - Images added later so some dragons done have one set, resets selection to start when editing old dragons, not needed otherwise
            cmbImage.SelectedItem = _Dragon.Image; 
            pbDragon.ImageLocation = _Dragon.Image;
        }

        protected virtual void pushData()
        {
            _Dragon.DateEdited = DateTime.Now;
            _Dragon.Name = txtName.Text;
            _Dragon.Age = Convert.ToInt16(txtAge.Text);
            _Dragon.Sex = cmbSex.Text;
            _Dragon.Size = Convert.ToInt16(txtSize.Text);
            _Dragon.Price = Convert.ToInt16(txtPrice.Text);
            _Dragon.Tame = cmbTame.Text;
            _Dragon.Available = cmbAvailable.Text;
            _Dragon.Image = cmbImage.Text;
        }

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetImage();
        }

        private void SetImage()
        {
            string lcImageLocation = (string)cmbImage.SelectedItem;
            pbDragon.ImageLocation = lcImageLocation;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                try
                {
                    pushData();
                    if (lblIDNumber.Text == "0")
                    {
                        MessageBox.Show(await ServiceClient.InsertDragonAsync(_Dragon));
                        lblIDNumber.Text = _Dragon.DragonID.ToString();
                    }
                    else
                        MessageBox.Show(await ServiceClient.UpdateDragonAsync(_Dragon));

                    Hide();
                }
                catch
                {
                    MessageBox.Show("Data Entry Error: Make sure all field contain correct data type", "Invalid Data");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
