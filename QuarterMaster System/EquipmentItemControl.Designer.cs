namespace QuarterMaster_System
{
    partial class EquipmentItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.lblItemAvailability = new System.Windows.Forms.Label();
            this.lblItemStoragelocation = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblItemExternalID = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tblItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tblItem
            // 
            this.tblItem.BackColor = System.Drawing.Color.Snow;
            this.tblItem.ColumnCount = 8;
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.14882F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.35537F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.94884F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.44926F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.99864F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09908F));
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tblItem.Controls.Add(this.lblItemCategory, 2, 0);
            this.tblItem.Controls.Add(this.btnMore, 7, 0);
            this.tblItem.Controls.Add(this.lblItemAvailability, 6, 0);
            this.tblItem.Controls.Add(this.lblItemStoragelocation, 5, 0);
            this.tblItem.Controls.Add(this.lblItemQuantity, 4, 0);
            this.tblItem.Controls.Add(this.lblItemExternalID, 3, 0);
            this.tblItem.Controls.Add(this.picIcon, 0, 0);
            this.tblItem.Controls.Add(this.lblItemName, 1, 0);
            this.tblItem.Location = new System.Drawing.Point(0, 0);
            this.tblItem.Margin = new System.Windows.Forms.Padding(0);
            this.tblItem.Name = "tblItem";
            this.tblItem.RowCount = 1;
            this.tblItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblItem.Size = new System.Drawing.Size(1914, 96);
            this.tblItem.TabIndex = 1;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemCategory.Location = new System.Drawing.Point(399, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(281, 96);
            this.lblItemCategory.TabIndex = 7;
            this.lblItemCategory.Text = "[Item Category]";
            this.lblItemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMore
            // 
            this.btnMore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMore.Location = new System.Drawing.Point(1752, 3);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(159, 90);
            this.btnMore.TabIndex = 6;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblItemAvailability
            // 
            this.lblItemAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemAvailability.Location = new System.Drawing.Point(1519, 0);
            this.lblItemAvailability.Name = "lblItemAvailability";
            this.lblItemAvailability.Size = new System.Drawing.Size(227, 96);
            this.lblItemAvailability.TabIndex = 5;
            this.lblItemAvailability.Text = "[Availability]";
            this.lblItemAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemStoragelocation
            // 
            this.lblItemStoragelocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemStoragelocation.Location = new System.Drawing.Point(1172, 0);
            this.lblItemStoragelocation.Name = "lblItemStoragelocation";
            this.lblItemStoragelocation.Size = new System.Drawing.Size(341, 96);
            this.lblItemStoragelocation.TabIndex = 4;
            this.lblItemStoragelocation.Text = "[Storage Location]";
            this.lblItemStoragelocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemQuantity.Location = new System.Drawing.Point(983, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(183, 96);
            this.lblItemQuantity.TabIndex = 3;
            this.lblItemQuantity.Text = "[Quantity]";
            this.lblItemQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemExternalID
            // 
            this.lblItemExternalID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemExternalID.Location = new System.Drawing.Point(686, 0);
            this.lblItemExternalID.Name = "lblItemExternalID";
            this.lblItemExternalID.Size = new System.Drawing.Size(291, 96);
            this.lblItemExternalID.TabIndex = 2;
            this.lblItemExternalID.Text = "[Item External ID]";
            this.lblItemExternalID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::QuarterMaster_System.Properties.Resources.Scouts_Australia_Logo;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(3, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(90, 90);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Location = new System.Drawing.Point(99, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(294, 96);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "[Item Name]";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblItem);
            this.Name = "EquipmentItemControl";
            this.Size = new System.Drawing.Size(1914, 112);
            this.tblItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblItem;
        private System.Windows.Forms.Label lblItemAvailability;
        private System.Windows.Forms.Label lblItemStoragelocation;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblItemExternalID;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label lblItemCategory;
    }
}
