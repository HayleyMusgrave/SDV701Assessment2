namespace SDV701_AdminApp
{
    partial class frmOrderList
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
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.lblSaleValue = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDragonID = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOrderList
            // 
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.Location = new System.Drawing.Point(15, 34);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(594, 173);
            this.lstOrderList.TabIndex = 1;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Location = new System.Drawing.Point(32, 223);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(88, 13);
            this.lblTotalSale.TabIndex = 2;
            this.lblTotalSale.Text = "Total Sale Value:";
            // 
            // lblSaleValue
            // 
            this.lblSaleValue.AutoSize = true;
            this.lblSaleValue.Location = new System.Drawing.Point(115, 223);
            this.lblSaleValue.Name = "lblSaleValue";
            this.lblSaleValue.Size = new System.Drawing.Size(25, 13);
            this.lblSaleValue.TabIndex = 3;
            this.lblSaleValue.Text = "<v>";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(418, 213);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteOrder.TabIndex = 4;
            this.btnDeleteOrder.Text = "Delete Selected Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(21, 18);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(29, 13);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "O-ID";
            // 
            // lblDragonID
            // 
            this.lblDragonID.AutoSize = true;
            this.lblDragonID.Location = new System.Drawing.Point(111, 18);
            this.lblDragonID.Name = "lblDragonID";
            this.lblDragonID.Size = new System.Drawing.Size(29, 13);
            this.lblDragonID.TabIndex = 7;
            this.lblDragonID.Text = "D-ID";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(193, 18);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(75, 13);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Sale Ammount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(294, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date of Purchase";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(441, 18);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Customer Name";
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 268);
            this.ControlBox = false;
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDragonID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblSaleValue);
            this.Controls.Add(this.lblTotalSale);
            this.Controls.Add(this.lstOrderList);
            this.Name = "frmOrderList";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.Label lblSaleValue;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblDragonID;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomer;
    }
}