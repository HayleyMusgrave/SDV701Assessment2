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
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.lvlSaleValue = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Location = new System.Drawing.Point(32, 9);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(57, 13);
            this.lblPurchases.TabIndex = 0;
            this.lblPurchases.Text = "Purchases";
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
            // lvlSaleValue
            // 
            this.lvlSaleValue.AutoSize = true;
            this.lvlSaleValue.Location = new System.Drawing.Point(115, 223);
            this.lvlSaleValue.Name = "lvlSaleValue";
            this.lvlSaleValue.Size = new System.Drawing.Size(25, 13);
            this.lvlSaleValue.TabIndex = 3;
            this.lvlSaleValue.Text = "<v>";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(418, 213);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteOrder.TabIndex = 4;
            this.btnDeleteOrder.Text = "Delete Selected Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 268);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lvlSaleValue);
            this.Controls.Add(this.lblTotalSale);
            this.Controls.Add(this.lstOrderList);
            this.Controls.Add(this.lblPurchases);
            this.Name = "frmOrderList";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.Label lvlSaleValue;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnClose;
    }
}