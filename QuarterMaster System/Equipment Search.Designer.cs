namespace QuarterMaster_System
{
    partial class Equipment_Search
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tblControlbar = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.flpEquipmentScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpTitelBar = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.tblControlbar.SuspendLayout();
            this.tlpTitelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(1798, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 64);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddItem.Location = new System.Drawing.Point(1622, 2);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(170, 64);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tblControlbar
            // 
            this.tblControlbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblControlbar.ColumnCount = 4;
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblControlbar.Controls.Add(this.txtSearch, 0, 0);
            this.tblControlbar.Controls.Add(this.btnFilter, 1, 0);
            this.tblControlbar.Controls.Add(this.btnBack, 3, 0);
            this.tblControlbar.Controls.Add(this.btnAddItem, 2, 0);
            this.tblControlbar.Location = new System.Drawing.Point(1, 0);
            this.tblControlbar.Margin = new System.Windows.Forms.Padding(0);
            this.tblControlbar.Name = "tblControlbar";
            this.tblControlbar.RowCount = 1;
            this.tblControlbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlbar.Size = new System.Drawing.Size(1920, 68);
            this.tblControlbar.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(3, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1549, 64);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Image = global::QuarterMaster_System.Properties.Resources.Filter;
            this.btnFilter.Location = new System.Drawing.Point(1558, 2);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(58, 64);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // flpEquipmentScroll
            // 
            this.flpEquipmentScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpEquipmentScroll.AutoScroll = true;
            this.flpEquipmentScroll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEquipmentScroll.Location = new System.Drawing.Point(1, 195);
            this.flpEquipmentScroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpEquipmentScroll.Name = "flpEquipmentScroll";
            this.flpEquipmentScroll.Size = new System.Drawing.Size(1920, 884);
            this.flpEquipmentScroll.TabIndex = 5;
            this.flpEquipmentScroll.WrapContents = false;
            // 
            // tlpTitelBar
            // 
            this.tlpTitelBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpTitelBar.BackColor = System.Drawing.Color.Snow;
            this.tlpTitelBar.ColumnCount = 8;
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.14818F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.35826F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.94821F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.44885F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9979F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09859F));
            this.tlpTitelBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tlpTitelBar.Controls.Add(this.lblCategory, 2, 0);
            this.tlpTitelBar.Controls.Add(this.lblAvailability, 6, 0);
            this.tlpTitelBar.Controls.Add(this.label1, 5, 0);
            this.tlpTitelBar.Controls.Add(this.lblQuantity, 4, 0);
            this.tlpTitelBar.Controls.Add(this.lblSerial, 3, 0);
            this.tlpTitelBar.Controls.Add(this.lblName, 1, 0);
            this.tlpTitelBar.Controls.Add(this.lblIcon, 0, 0);
            this.tlpTitelBar.Location = new System.Drawing.Point(1, 122);
            this.tlpTitelBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTitelBar.Name = "tlpTitelBar";
            this.tlpTitelBar.RowCount = 1;
            this.tlpTitelBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitelBar.Size = new System.Drawing.Size(1920, 69);
            this.tlpTitelBar.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(395, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(277, 69);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(1501, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(224, 69);
            this.lblAvailability.TabIndex = 5;
            this.lblAvailability.Text = "Availability";
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1158, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Storage Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(971, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(181, 69);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(678, 0);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(287, 69);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "Serial";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(99, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(290, 69);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Location = new System.Drawing.Point(3, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(90, 69);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "Icon";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Equipment_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tlpTitelBar);
            this.Controls.Add(this.flpEquipmentScroll);
            this.Controls.Add(this.tblControlbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Equipment_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tblControlbar.ResumeLayout(false);
            this.tblControlbar.PerformLayout();
            this.tlpTitelBar.ResumeLayout(false);
            this.tlpTitelBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TableLayoutPanel tblControlbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpEquipmentScroll;
        private System.Windows.Forms.TableLayoutPanel tlpTitelBar;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategory;
    }
}