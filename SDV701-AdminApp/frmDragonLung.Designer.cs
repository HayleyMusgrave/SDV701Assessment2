namespace SDV701_AdminApp
{
    partial class frmDragonLung
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
            this.cmbFlight = new System.Windows.Forms.ComboBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblWhiskers = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWhiskers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbFlight
            // 
            this.cmbFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlight.FormattingEnabled = true;
            this.cmbFlight.Location = new System.Drawing.Point(304, 107);
            this.cmbFlight.Name = "cmbFlight";
            this.cmbFlight.Size = new System.Drawing.Size(143, 21);
            this.cmbFlight.TabIndex = 37;
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(241, 110);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(38, 13);
            this.lblFlight.TabIndex = 36;
            this.lblFlight.Text = "Flight?";
            // 
            // lblWhiskers
            // 
            this.lblWhiskers.AutoSize = true;
            this.lblWhiskers.Location = new System.Drawing.Point(241, 75);
            this.lblWhiskers.Name = "lblWhiskers";
            this.lblWhiskers.Size = new System.Drawing.Size(51, 13);
            this.lblWhiskers.TabIndex = 35;
            this.lblWhiskers.Text = "Whiskers";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(241, 40);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 34;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(304, 37);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(143, 20);
            this.txtLength.TabIndex = 33;
            // 
            // txtWhiskers
            // 
            this.txtWhiskers.Location = new System.Drawing.Point(304, 72);
            this.txtWhiskers.Name = "txtWhiskers";
            this.txtWhiskers.Size = new System.Drawing.Size(143, 20);
            this.txtWhiskers.TabIndex = 32;
            // 
            // frmDragonLung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.cmbFlight);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.lblWhiskers);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWhiskers);
            this.Name = "frmDragonLung";
            this.Controls.SetChildIndex(this.txtWhiskers, 0);
            this.Controls.SetChildIndex(this.txtLength, 0);
            this.Controls.SetChildIndex(this.lblLength, 0);
            this.Controls.SetChildIndex(this.lblWhiskers, 0);
            this.Controls.SetChildIndex(this.lblFlight, 0);
            this.Controls.SetChildIndex(this.cmbFlight, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFlight;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblWhiskers;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWhiskers;
    }
}
