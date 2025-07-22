namespace QuarterMaster_System
{
    partial class AddItemControl
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
            this.tblControlbar = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flpItemControlScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.nudNumItem = new System.Windows.Forms.NumericUpDown();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.tblControlbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tblControlbar
            // 
            this.tblControlbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblControlbar.ColumnCount = 3;
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tblControlbar.Controls.Add(this.txtSearch, 0, 0);
            this.tblControlbar.Controls.Add(this.btnFilter, 1, 0);
            this.tblControlbar.Controls.Add(this.btnCancel, 2, 0);
            this.tblControlbar.Location = new System.Drawing.Point(0, 0);
            this.tblControlbar.Margin = new System.Windows.Forms.Padding(0);
            this.tblControlbar.Name = "tblControlbar";
            this.tblControlbar.RowCount = 1;
            this.tblControlbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlbar.Size = new System.Drawing.Size(1920, 68);
            this.tblControlbar.TabIndex = 5;
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
            this.txtSearch.Size = new System.Drawing.Size(1674, 64);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Image = global::QuarterMaster_System.Properties.Resources.Filter;
            this.btnFilter.Location = new System.Drawing.Point(1683, 2);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(58, 64);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1747, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 62);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1800, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flpItemControlScroll
            // 
            this.flpItemControlScroll.AutoScroll = true;
            this.flpItemControlScroll.Location = new System.Drawing.Point(0, 178);
            this.flpItemControlScroll.Name = "flpItemControlScroll";
            this.flpItemControlScroll.Size = new System.Drawing.Size(1920, 622);
            this.flpItemControlScroll.TabIndex = 7;
            // 
            // nudNumItem
            // 
            this.nudNumItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumItem.Location = new System.Drawing.Point(1200, 90);
            this.nudNumItem.Name = "nudNumItem";
            this.nudNumItem.Size = new System.Drawing.Size(132, 79);
            this.nudNumItem.TabIndex = 0;
            this.nudNumItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.Location = new System.Drawing.Point(145, 90);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(905, 76);
            this.lblNumItems.TabIndex = 8;
            this.lblNumItems.Text = "Quantity of item to be added: ";
            // 
            // AddItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.nudNumItem);
            this.Controls.Add(this.flpItemControlScroll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblControlbar);
            this.Name = "AddItemControl";
            this.Size = new System.Drawing.Size(1920, 800);
            this.tblControlbar.ResumeLayout(false);
            this.tblControlbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblControlbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpItemControlScroll;
        private System.Windows.Forms.NumericUpDown nudNumItem;
        private System.Windows.Forms.Label lblNumItems;
    }
}
