namespace SDV701_AdminApp
{
    partial class frmDragonWestern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPoison = new System.Windows.Forms.ComboBox();
            this.lblPoison = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblStance = new System.Windows.Forms.Label();
            this.txtStance = new System.Windows.Forms.TextBox();
            this.cmbFire = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbPoison
            // 
            this.cmbPoison.FormattingEnabled = true;
            this.cmbPoison.Location = new System.Drawing.Point(304, 107);
            this.cmbPoison.Name = "cmbPoison";
            this.cmbPoison.Size = new System.Drawing.Size(143, 21);
            this.cmbPoison.TabIndex = 37;
            // 
            // lblPoison
            // 
            this.lblPoison.AutoSize = true;
            this.lblPoison.Location = new System.Drawing.Point(241, 110);
            this.lblPoison.Name = "lblPoison";
            this.lblPoison.Size = new System.Drawing.Size(45, 13);
            this.lblPoison.TabIndex = 36;
            this.lblPoison.Text = "Poison?";
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Location = new System.Drawing.Point(241, 75);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(30, 13);
            this.lblFire.TabIndex = 35;
            this.lblFire.Text = "Fire?";
            // 
            // lblStance
            // 
            this.lblStance.AutoSize = true;
            this.lblStance.Location = new System.Drawing.Point(241, 40);
            this.lblStance.Name = "lblStance";
            this.lblStance.Size = new System.Drawing.Size(41, 13);
            this.lblStance.TabIndex = 34;
            this.lblStance.Text = "Stance";
            // 
            // txtStance
            // 
            this.txtStance.Location = new System.Drawing.Point(304, 37);
            this.txtStance.Name = "txtStance";
            this.txtStance.Size = new System.Drawing.Size(143, 20);
            this.txtStance.TabIndex = 33;
            // 
            // cmbFire
            // 
            this.cmbFire.FormattingEnabled = true;
            this.cmbFire.Location = new System.Drawing.Point(304, 72);
            this.cmbFire.Name = "cmbFire";
            this.cmbFire.Size = new System.Drawing.Size(143, 21);
            this.cmbFire.TabIndex = 38;
            // 
            // frmDragonWestern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.cmbFire);
            this.Controls.Add(this.cmbPoison);
            this.Controls.Add(this.lblPoison);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.lblStance);
            this.Controls.Add(this.txtStance);
            this.Name = "frmDragonWestern";
            this.Controls.SetChildIndex(this.txtStance, 0);
            this.Controls.SetChildIndex(this.lblStance, 0);
            this.Controls.SetChildIndex(this.lblFire, 0);
            this.Controls.SetChildIndex(this.lblPoison, 0);
            this.Controls.SetChildIndex(this.cmbPoison, 0);
            this.Controls.SetChildIndex(this.cmbFire, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPoison;
        private System.Windows.Forms.Label lblPoison;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label lblStance;
        private System.Windows.Forms.TextBox txtStance;
        private System.Windows.Forms.ComboBox cmbFire;
    }
}
