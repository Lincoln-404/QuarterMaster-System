namespace QuarterMaster_System
{
    partial class MoreMenuControl
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flpControlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.txtItemExternalID = new System.Windows.Forms.TextBox();
            this.txtItemInternalID = new System.Windows.Forms.TextBox();
            this.txtItemCondition = new System.Windows.Forms.TextBox();
            this.txtItemCategory = new System.Windows.Forms.TextBox();
            this.lblExternalID = new System.Windows.Forms.Label();
            this.lblInteralID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemLocation = new System.Windows.Forms.TextBox();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            this.flpControlButtons.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(4, 3);
            this.picIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(222, 200);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(3, 252);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(91, 31);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(231, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(231, 61);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(134, 31);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(231, 99);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(133, 31);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(232, 137);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(142, 31);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "Available:";
            // 
            // picAvailable
            // 
            this.picAvailable.BackColor = System.Drawing.Color.Red;
            this.picAvailable.Location = new System.Drawing.Point(384, 139);
            this.picAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(44, 27);
            this.picAvailable.TabIndex = 11;
            this.picAvailable.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(4, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 61);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(144, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 61);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Item";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(284, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 61);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flpControlButtons
            // 
            this.flpControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpControlButtons.Controls.Add(this.btnClose);
            this.flpControlButtons.Controls.Add(this.btnEdit);
            this.flpControlButtons.Controls.Add(this.btnDelete);
            this.flpControlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpControlButtons.Location = new System.Drawing.Point(893, 3);
            this.flpControlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpControlButtons.Name = "flpControlButtons";
            this.flpControlButtons.Size = new System.Drawing.Size(421, 66);
            this.flpControlButtons.TabIndex = 15;
            // 
            // tlpData
            // 
            this.tlpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpData.ColumnCount = 4;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpData.Controls.Add(this.txtItemExternalID, 3, 1);
            this.tlpData.Controls.Add(this.txtItemInternalID, 3, 0);
            this.tlpData.Controls.Add(this.txtItemCondition, 1, 1);
            this.tlpData.Controls.Add(this.txtItemCategory, 1, 0);
            this.tlpData.Controls.Add(this.lblExternalID, 2, 1);
            this.tlpData.Controls.Add(this.lblInteralID, 2, 0);
            this.tlpData.Controls.Add(this.lblCategory, 0, 0);
            this.tlpData.Controls.Add(this.lblCondition, 0, 1);
            this.tlpData.Location = new System.Drawing.Point(520, 278);
            this.tlpData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 4;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.Size = new System.Drawing.Size(792, 418);
            this.tlpData.TabIndex = 16;
            // 
            // txtItemExternalID
            // 
            this.txtItemExternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemExternalID.Location = new System.Drawing.Point(556, 106);
            this.txtItemExternalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemExternalID.Name = "txtItemExternalID";
            this.txtItemExternalID.ReadOnly = true;
            this.txtItemExternalID.Size = new System.Drawing.Size(147, 32);
            this.txtItemExternalID.TabIndex = 21;
            this.txtItemExternalID.Text = "[Items Serial]";
            // 
            // txtItemInternalID
            // 
            this.txtItemInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemInternalID.Location = new System.Drawing.Point(556, 2);
            this.txtItemInternalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemInternalID.Name = "txtItemInternalID";
            this.txtItemInternalID.ReadOnly = true;
            this.txtItemInternalID.Size = new System.Drawing.Size(147, 32);
            this.txtItemInternalID.TabIndex = 20;
            this.txtItemInternalID.Text = "[Items Interal ID]";
            // 
            // txtItemCondition
            // 
            this.txtItemCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCondition.Location = new System.Drawing.Point(161, 106);
            this.txtItemCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCondition.Name = "txtItemCondition";
            this.txtItemCondition.ReadOnly = true;
            this.txtItemCondition.Size = new System.Drawing.Size(147, 32);
            this.txtItemCondition.TabIndex = 20;
            this.txtItemCondition.Text = "[Items Condition]";
            // 
            // txtItemCategory
            // 
            this.txtItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCategory.Location = new System.Drawing.Point(161, 2);
            this.txtItemCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCategory.Name = "txtItemCategory";
            this.txtItemCategory.ReadOnly = true;
            this.txtItemCategory.Size = new System.Drawing.Size(147, 32);
            this.txtItemCategory.TabIndex = 19;
            this.txtItemCategory.Text = "[Items Category]";
            // 
            // lblExternalID
            // 
            this.lblExternalID.AutoSize = true;
            this.lblExternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExternalID.Location = new System.Drawing.Point(398, 104);
            this.lblExternalID.Name = "lblExternalID";
            this.lblExternalID.Size = new System.Drawing.Size(89, 29);
            this.lblExternalID.TabIndex = 6;
            this.lblExternalID.Text = "Serial:";
            // 
            // lblInteralID
            // 
            this.lblInteralID.AutoSize = true;
            this.lblInteralID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteralID.Location = new System.Drawing.Point(398, 0);
            this.lblInteralID.Name = "lblInteralID";
            this.lblInteralID.Size = new System.Drawing.Size(139, 29);
            this.lblInteralID.TabIndex = 4;
            this.lblInteralID.Text = "Internal ID:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(125, 29);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(3, 104);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(132, 29);
            this.lblCondition.TabIndex = 2;
            this.lblCondition.Text = "Condition:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbNotes.Location = new System.Drawing.Point(4, 284);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ReadOnly = true;
            this.rtbNotes.Size = new System.Drawing.Size(496, 413);
            this.rtbNotes.TabIndex = 1;
            this.rtbNotes.TabStop = false;
            this.rtbNotes.Text = "";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(332, 23);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(168, 36);
            this.txtItemName.TabIndex = 17;
            this.txtItemName.Text = "[Items Name]";
            // 
            // txtItemLocation
            // 
            this.txtItemLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemLocation.Location = new System.Drawing.Point(356, 61);
            this.txtItemLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemLocation.Name = "txtItemLocation";
            this.txtItemLocation.ReadOnly = true;
            this.txtItemLocation.Size = new System.Drawing.Size(194, 36);
            this.txtItemLocation.TabIndex = 18;
            this.txtItemLocation.Text = "[Items Location]";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQuantity.Location = new System.Drawing.Point(355, 99);
            this.txtItemQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.ReadOnly = true;
            this.txtItemQuantity.Size = new System.Drawing.Size(195, 36);
            this.txtItemQuantity.TabIndex = 19;
            this.txtItemQuantity.Text = "[Items Quantity]";
            // 
            // MoreMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.txtItemLocation);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.tlpData);
            this.Controls.Add(this.flpControlButtons);
            this.Controls.Add(this.picAvailable);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.picIcon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoreMenuControl";
            this.Size = new System.Drawing.Size(1317, 704);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            this.flpControlButtons.ResumeLayout(false);
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpControlButtons;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblInteralID;
        private System.Windows.Forms.Label lblExternalID;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemLocation;
        private System.Windows.Forms.TextBox txtItemExternalID;
        private System.Windows.Forms.TextBox txtItemInternalID;
        private System.Windows.Forms.TextBox txtItemCondition;
        private System.Windows.Forms.TextBox txtItemCategory;
        private System.Windows.Forms.TextBox txtItemQuantity;
    }
}
