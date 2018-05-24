namespace SDV701_AdminApp
{
    partial class frmBreed
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
            this.lblBreedName = new System.Windows.Forms.Label();
            this.lblBreedCost = new System.Windows.Forms.Label();
            this.lblBreedRarity = new System.Windows.Forms.Label();
            this.lblBreedOrigin = new System.Windows.Forms.Label();
            this.lblBreedNameList = new System.Windows.Forms.Label();
            this.lblSortOrder = new System.Windows.Forms.Label();
            this.cmbSortOrder = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbDragonType = new System.Windows.Forms.ComboBox();
            this.btnAddDragon = new System.Windows.Forms.Button();
            this.btnEditDragon = new System.Windows.Forms.Button();
            this.btnRemoveDragon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBreedName
            // 
            this.lblBreedName.AutoSize = true;
            this.lblBreedName.Location = new System.Drawing.Point(215, 25);
            this.lblBreedName.Name = "lblBreedName";
            this.lblBreedName.Size = new System.Drawing.Size(109, 13);
            this.lblBreedName.TabIndex = 0;
            this.lblBreedName.Text = "Name: <BreedName>";
            // 
            // lblBreedCost
            // 
            this.lblBreedCost.AutoSize = true;
            this.lblBreedCost.Location = new System.Drawing.Point(437, 25);
            this.lblBreedCost.Name = "lblBreedCost";
            this.lblBreedCost.Size = new System.Drawing.Size(97, 13);
            this.lblBreedCost.TabIndex = 1;
            this.lblBreedCost.Text = "Base Price: <Cost>";
            // 
            // lblBreedRarity
            // 
            this.lblBreedRarity.AutoSize = true;
            this.lblBreedRarity.Location = new System.Drawing.Point(215, 48);
            this.lblBreedRarity.Name = "lblBreedRarity";
            this.lblBreedRarity.Size = new System.Drawing.Size(107, 13);
            this.lblBreedRarity.TabIndex = 2;
            this.lblBreedRarity.Text = "Rarity: <BreedRarity>";
            // 
            // lblBreedOrigin
            // 
            this.lblBreedOrigin.AutoSize = true;
            this.lblBreedOrigin.Location = new System.Drawing.Point(437, 48);
            this.lblBreedOrigin.Name = "lblBreedOrigin";
            this.lblBreedOrigin.Size = new System.Drawing.Size(107, 13);
            this.lblBreedOrigin.TabIndex = 3;
            this.lblBreedOrigin.Text = "Origin: <BreedOrigin>";
            // 
            // lblBreedNameList
            // 
            this.lblBreedNameList.AutoSize = true;
            this.lblBreedNameList.Location = new System.Drawing.Point(127, 85);
            this.lblBreedNameList.Name = "lblBreedNameList";
            this.lblBreedNameList.Size = new System.Drawing.Size(118, 13);
            this.lblBreedNameList.TabIndex = 4;
            this.lblBreedNameList.Text = "<BreedName> Dragons";
            // 
            // lblSortOrder
            // 
            this.lblSortOrder.AutoSize = true;
            this.lblSortOrder.Location = new System.Drawing.Point(366, 85);
            this.lblSortOrder.Name = "lblSortOrder";
            this.lblSortOrder.Size = new System.Drawing.Size(58, 13);
            this.lblSortOrder.TabIndex = 5;
            this.lblSortOrder.Text = "Sort Order:";
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.FormattingEnabled = true;
            this.cmbSortOrder.Location = new System.Drawing.Point(423, 82);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbSortOrder.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 277);
            this.listBox1.TabIndex = 7;
            // 
            // cmbDragonType
            // 
            this.cmbDragonType.FormattingEnabled = true;
            this.cmbDragonType.Location = new System.Drawing.Point(234, 400);
            this.cmbDragonType.Name = "cmbDragonType";
            this.cmbDragonType.Size = new System.Drawing.Size(141, 21);
            this.cmbDragonType.TabIndex = 8;
            // 
            // btnAddDragon
            // 
            this.btnAddDragon.Location = new System.Drawing.Point(26, 398);
            this.btnAddDragon.Name = "btnAddDragon";
            this.btnAddDragon.Size = new System.Drawing.Size(190, 23);
            this.btnAddDragon.TabIndex = 9;
            this.btnAddDragon.Text = "Add";
            this.btnAddDragon.UseVisualStyleBackColor = true;
            // 
            // btnEditDragon
            // 
            this.btnEditDragon.Location = new System.Drawing.Point(26, 427);
            this.btnEditDragon.Name = "btnEditDragon";
            this.btnEditDragon.Size = new System.Drawing.Size(190, 23);
            this.btnEditDragon.TabIndex = 10;
            this.btnEditDragon.Text = "Edit";
            this.btnEditDragon.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDragon
            // 
            this.btnRemoveDragon.Location = new System.Drawing.Point(615, 398);
            this.btnRemoveDragon.Name = "btnRemoveDragon";
            this.btnRemoveDragon.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveDragon.TabIndex = 11;
            this.btnRemoveDragon.Text = "Remove";
            this.btnRemoveDragon.UseVisualStyleBackColor = true;
            // 
            // frmBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.btnRemoveDragon);
            this.Controls.Add(this.btnEditDragon);
            this.Controls.Add(this.btnAddDragon);
            this.Controls.Add(this.cmbDragonType);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbSortOrder);
            this.Controls.Add(this.lblSortOrder);
            this.Controls.Add(this.lblBreedNameList);
            this.Controls.Add(this.lblBreedOrigin);
            this.Controls.Add(this.lblBreedRarity);
            this.Controls.Add(this.lblBreedCost);
            this.Controls.Add(this.lblBreedName);
            this.Name = "frmBreed";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreedName;
        private System.Windows.Forms.Label lblBreedCost;
        private System.Windows.Forms.Label lblBreedRarity;
        private System.Windows.Forms.Label lblBreedOrigin;
        private System.Windows.Forms.Label lblBreedNameList;
        private System.Windows.Forms.Label lblSortOrder;
        private System.Windows.Forms.ComboBox cmbSortOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbDragonType;
        private System.Windows.Forms.Button btnAddDragon;
        private System.Windows.Forms.Button btnEditDragon;
        private System.Windows.Forms.Button btnRemoveDragon;
    }
}