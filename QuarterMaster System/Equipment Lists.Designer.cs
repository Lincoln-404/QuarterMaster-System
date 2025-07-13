namespace QuarterMaster_System
{
    partial class EquipmentLists
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
            this.tplControlbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewList = new System.Windows.Forms.Button();
            this.tlpParentListScroll = new System.Windows.Forms.TableLayoutPanel();
            this.flpLeftListScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRightListScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.tplControlbar.SuspendLayout();
            this.tlpParentListScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(1727, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tplControlbar
            // 
            this.tplControlbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tplControlbar.BackColor = System.Drawing.Color.Snow;
            this.tplControlbar.ColumnCount = 3;
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tplControlbar.Controls.Add(this.btnNewList, 0, 0);
            this.tplControlbar.Controls.Add(this.btnBack, 2, 0);
            this.tplControlbar.Location = new System.Drawing.Point(12, 12);
            this.tplControlbar.Name = "tplControlbar";
            this.tplControlbar.RowCount = 1;
            this.tplControlbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplControlbar.Size = new System.Drawing.Size(1896, 68);
            this.tplControlbar.TabIndex = 1;
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewList.Location = new System.Drawing.Point(3, 3);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(187, 62);
            this.btnNewList.TabIndex = 1;
            this.btnNewList.Text = "New List";
            this.btnNewList.UseVisualStyleBackColor = true;
            // 
            // tlpParentListScroll
            // 
            this.tlpParentListScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpParentListScroll.AutoScroll = true;
            this.tlpParentListScroll.ColumnCount = 3;
            this.tlpParentListScroll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 703F));
            this.tlpParentListScroll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParentListScroll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 699F));
            this.tlpParentListScroll.Controls.Add(this.flpLeftListScroll, 0, 0);
            this.tlpParentListScroll.Controls.Add(this.flpRightListScroll, 2, 0);
            this.tlpParentListScroll.Location = new System.Drawing.Point(157, 194);
            this.tlpParentListScroll.Name = "tlpParentListScroll";
            this.tlpParentListScroll.RowCount = 1;
            this.tlpParentListScroll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParentListScroll.Size = new System.Drawing.Size(1614, 831);
            this.tlpParentListScroll.TabIndex = 2;
            // 
            // flpLeftListScroll
            // 
            this.flpLeftListScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLeftListScroll.Location = new System.Drawing.Point(3, 3);
            this.flpLeftListScroll.Name = "flpLeftListScroll";
            this.flpLeftListScroll.Size = new System.Drawing.Size(697, 825);
            this.flpLeftListScroll.TabIndex = 0;
            // 
            // flpRightListScroll
            // 
            this.flpRightListScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRightListScroll.Location = new System.Drawing.Point(918, 3);
            this.flpRightListScroll.Name = "flpRightListScroll";
            this.flpRightListScroll.Size = new System.Drawing.Size(693, 825);
            this.flpRightListScroll.TabIndex = 1;
            // 
            // EquipmentLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tlpParentListScroll);
            this.Controls.Add(this.tplControlbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarterMaster [Equipment Lists]";
            this.tplControlbar.ResumeLayout(false);
            this.tlpParentListScroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tplControlbar;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.TableLayoutPanel tlpParentListScroll;
        private System.Windows.Forms.FlowLayoutPanel flpLeftListScroll;
        private System.Windows.Forms.FlowLayoutPanel flpRightListScroll;
    }
}