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
            this.lstDragons = new System.Windows.Forms.ListBox();
            this.cmbDragonType = new System.Windows.Forms.ComboBox();
            this.btnAddDragon = new System.Windows.Forms.Button();
            this.btnEditDragon = new System.Windows.Forms.Button();
            this.btnRemoveDragon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lbllAge = new System.Windows.Forms.Label();
            this.lbllPrice = new System.Windows.Forms.Label();
            this.lbllAvailable = new System.Windows.Forms.Label();
            this.lbllSex = new System.Windows.Forms.Label();
            this.lbllSpecies = new System.Windows.Forms.Label();
            this.lbllSize = new System.Windows.Forms.Label();
            this.lbllEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBreedName
            // 
            this.lblBreedName.AutoSize = true;
            this.lblBreedName.Location = new System.Drawing.Point(151, 25);
            this.lblBreedName.Name = "lblBreedName";
            this.lblBreedName.Size = new System.Drawing.Size(109, 13);
            this.lblBreedName.TabIndex = 0;
            this.lblBreedName.Text = "Name: <BreedName>";
            // 
            // lblBreedCost
            // 
            this.lblBreedCost.AutoSize = true;
            this.lblBreedCost.Location = new System.Drawing.Point(373, 25);
            this.lblBreedCost.Name = "lblBreedCost";
            this.lblBreedCost.Size = new System.Drawing.Size(97, 13);
            this.lblBreedCost.TabIndex = 1;
            this.lblBreedCost.Text = "Base Price: <Cost>";
            // 
            // lblBreedRarity
            // 
            this.lblBreedRarity.AutoSize = true;
            this.lblBreedRarity.Location = new System.Drawing.Point(151, 48);
            this.lblBreedRarity.Name = "lblBreedRarity";
            this.lblBreedRarity.Size = new System.Drawing.Size(107, 13);
            this.lblBreedRarity.TabIndex = 2;
            this.lblBreedRarity.Text = "Rarity: <BreedRarity>";
            // 
            // lblBreedOrigin
            // 
            this.lblBreedOrigin.AutoSize = true;
            this.lblBreedOrigin.Location = new System.Drawing.Point(373, 48);
            this.lblBreedOrigin.Name = "lblBreedOrigin";
            this.lblBreedOrigin.Size = new System.Drawing.Size(107, 13);
            this.lblBreedOrigin.TabIndex = 3;
            this.lblBreedOrigin.Text = "Origin: <BreedOrigin>";
            // 
            // lblBreedNameList
            // 
            this.lblBreedNameList.AutoSize = true;
            this.lblBreedNameList.Location = new System.Drawing.Point(75, 85);
            this.lblBreedNameList.Name = "lblBreedNameList";
            this.lblBreedNameList.Size = new System.Drawing.Size(118, 13);
            this.lblBreedNameList.TabIndex = 4;
            this.lblBreedNameList.Text = "<BreedName> Dragons";
            // 
            // lblSortOrder
            // 
            this.lblSortOrder.AutoSize = true;
            this.lblSortOrder.Location = new System.Drawing.Point(302, 85);
            this.lblSortOrder.Name = "lblSortOrder";
            this.lblSortOrder.Size = new System.Drawing.Size(58, 13);
            this.lblSortOrder.TabIndex = 5;
            this.lblSortOrder.Text = "Sort Order:";
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortOrder.FormattingEnabled = true;
            this.cmbSortOrder.Location = new System.Drawing.Point(359, 82);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbSortOrder.TabIndex = 6;
            this.cmbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cmbSortOrder_SelectedIndexChanged);
            // 
            // lstDragons
            // 
            this.lstDragons.FormattingEnabled = true;
            this.lstDragons.Location = new System.Drawing.Point(26, 135);
            this.lstDragons.Name = "lstDragons";
            this.lstDragons.Size = new System.Drawing.Size(566, 251);
            this.lstDragons.TabIndex = 7;
            this.lstDragons.DoubleClick += new System.EventHandler(this.lstDragons_DoubleClick);
            // 
            // cmbDragonType
            // 
            this.cmbDragonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btnAddDragon.Click += new System.EventHandler(this.btnAddDragon_Click);
            // 
            // btnEditDragon
            // 
            this.btnEditDragon.Location = new System.Drawing.Point(26, 427);
            this.btnEditDragon.Name = "btnEditDragon";
            this.btnEditDragon.Size = new System.Drawing.Size(190, 23);
            this.btnEditDragon.TabIndex = 10;
            this.btnEditDragon.Text = "Edit";
            this.btnEditDragon.UseVisualStyleBackColor = true;
            this.btnEditDragon.Click += new System.EventHandler(this.btnEditDragon_Click);
            // 
            // btnRemoveDragon
            // 
            this.btnRemoveDragon.Location = new System.Drawing.Point(457, 398);
            this.btnRemoveDragon.Name = "btnRemoveDragon";
            this.btnRemoveDragon.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveDragon.TabIndex = 11;
            this.btnRemoveDragon.Text = "Remove";
            this.btnRemoveDragon.UseVisualStyleBackColor = true;
            this.btnRemoveDragon.Click += new System.EventHandler(this.btnRemoveDragon_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(499, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 119);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Location = new System.Drawing.Point(73, 119);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(35, 13);
            this.lbllName.TabIndex = 14;
            this.lbllName.Text = "Name";
            // 
            // lbllAge
            // 
            this.lbllAge.AutoSize = true;
            this.lbllAge.Location = new System.Drawing.Point(215, 119);
            this.lbllAge.Name = "lbllAge";
            this.lbllAge.Size = new System.Drawing.Size(26, 13);
            this.lbllAge.TabIndex = 15;
            this.lbllAge.Text = "Age";
            // 
            // lbllPrice
            // 
            this.lbllPrice.AutoSize = true;
            this.lbllPrice.Location = new System.Drawing.Point(356, 119);
            this.lbllPrice.Name = "lbllPrice";
            this.lbllPrice.Size = new System.Drawing.Size(31, 13);
            this.lbllPrice.TabIndex = 16;
            this.lbllPrice.Text = "Price";
            // 
            // lbllAvailable
            // 
            this.lbllAvailable.AutoSize = true;
            this.lbllAvailable.Location = new System.Drawing.Point(446, 119);
            this.lbllAvailable.Name = "lbllAvailable";
            this.lbllAvailable.Size = new System.Drawing.Size(56, 13);
            this.lbllAvailable.TabIndex = 17;
            this.lbllAvailable.Text = "Available?";
            // 
            // lbllSex
            // 
            this.lbllSex.AutoSize = true;
            this.lbllSex.Location = new System.Drawing.Point(263, 119);
            this.lbllSex.Name = "lbllSex";
            this.lbllSex.Size = new System.Drawing.Size(25, 13);
            this.lbllSex.TabIndex = 18;
            this.lbllSex.Text = "Sex";
            // 
            // lbllSpecies
            // 
            this.lbllSpecies.AutoSize = true;
            this.lbllSpecies.Location = new System.Drawing.Point(123, 119);
            this.lbllSpecies.Name = "lbllSpecies";
            this.lbllSpecies.Size = new System.Drawing.Size(45, 13);
            this.lbllSpecies.TabIndex = 19;
            this.lbllSpecies.Text = "Species";
            // 
            // lbllSize
            // 
            this.lbllSize.AutoSize = true;
            this.lbllSize.Location = new System.Drawing.Point(311, 119);
            this.lbllSize.Name = "lbllSize";
            this.lbllSize.Size = new System.Drawing.Size(27, 13);
            this.lbllSize.TabIndex = 20;
            this.lbllSize.Text = "Size";
            // 
            // lbllEdit
            // 
            this.lbllEdit.AutoSize = true;
            this.lbllEdit.Location = new System.Drawing.Point(517, 119);
            this.lbllEdit.Name = "lbllEdit";
            this.lbllEdit.Size = new System.Drawing.Size(48, 13);
            this.lbllEdit.TabIndex = 21;
            this.lbllEdit.Text = "Last Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tame?";
            // 
            // frmBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllEdit);
            this.Controls.Add(this.lbllSize);
            this.Controls.Add(this.lbllSpecies);
            this.Controls.Add(this.lbllSex);
            this.Controls.Add(this.lbllAvailable);
            this.Controls.Add(this.lbllPrice);
            this.Controls.Add(this.lbllAge);
            this.Controls.Add(this.lbllName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveDragon);
            this.Controls.Add(this.btnEditDragon);
            this.Controls.Add(this.btnAddDragon);
            this.Controls.Add(this.cmbDragonType);
            this.Controls.Add(this.lstDragons);
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
        private System.Windows.Forms.ListBox lstDragons;
        private System.Windows.Forms.ComboBox cmbDragonType;
        private System.Windows.Forms.Button btnAddDragon;
        private System.Windows.Forms.Button btnEditDragon;
        private System.Windows.Forms.Button btnRemoveDragon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lbllAge;
        private System.Windows.Forms.Label lbllPrice;
        private System.Windows.Forms.Label lbllAvailable;
        private System.Windows.Forms.Label lbllSex;
        private System.Windows.Forms.Label lbllSpecies;
        private System.Windows.Forms.Label lbllSize;
        private System.Windows.Forms.Label lbllEdit;
        private System.Windows.Forms.Label label1;
    }
}