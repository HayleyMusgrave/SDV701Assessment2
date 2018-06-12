namespace SDV701_AdminApp
{
    partial class frmMain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstBreeds = new System.Windows.Forms.ListBox();
            this.btnViewDragons = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnSaveQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(84, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // lstBreeds
            // 
            this.lstBreeds.FormattingEnabled = true;
            this.lstBreeds.Location = new System.Drawing.Point(12, 36);
            this.lstBreeds.Name = "lstBreeds";
            this.lstBreeds.Size = new System.Drawing.Size(287, 147);
            this.lstBreeds.TabIndex = 1;
            this.lstBreeds.DoubleClick += new System.EventHandler(this.lstBreeds_DoubleClick);
            // 
            // btnViewDragons
            // 
            this.btnViewDragons.Location = new System.Drawing.Point(315, 36);
            this.btnViewDragons.Name = "btnViewDragons";
            this.btnViewDragons.Size = new System.Drawing.Size(120, 23);
            this.btnViewDragons.TabIndex = 2;
            this.btnViewDragons.Text = "View Dragons";
            this.btnViewDragons.UseVisualStyleBackColor = true;
            this.btnViewDragons.Click += new System.EventHandler(this.btnViewDragons_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(315, 65);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(120, 23);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "Check Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnSaveQuit
            // 
            this.btnSaveQuit.Location = new System.Drawing.Point(315, 160);
            this.btnSaveQuit.Name = "btnSaveQuit";
            this.btnSaveQuit.Size = new System.Drawing.Size(120, 23);
            this.btnSaveQuit.TabIndex = 4;
            this.btnSaveQuit.Text = "Quit";
            this.btnSaveQuit.UseVisualStyleBackColor = true;
            this.btnSaveQuit.Click += new System.EventHandler(this.btnSaveQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 199);
            this.Controls.Add(this.btnSaveQuit);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnViewDragons);
            this.Controls.Add(this.lstBreeds);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lstBreeds;
        private System.Windows.Forms.Button btnViewDragons;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnSaveQuit;
    }
}

