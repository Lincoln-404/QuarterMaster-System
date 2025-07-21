namespace QuarterMaster_System
{
    partial class EquipmentListView
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
            this.tplControlbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblListName = new System.Windows.Forms.Label();
            this.lblListSize = new System.Windows.Forms.Label();
            this.lblListOwner = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.flpListItemScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.tplControlbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplControlbar
            // 
            this.tplControlbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tplControlbar.BackColor = System.Drawing.Color.Snow;
            this.tplControlbar.ColumnCount = 5;
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplControlbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tplControlbar.Controls.Add(this.btnDeleteList, 2, 0);
            this.tplControlbar.Controls.Add(this.btnBookList, 1, 0);
            this.tplControlbar.Controls.Add(this.btnAddItem, 0, 0);
            this.tplControlbar.Controls.Add(this.btnBack, 4, 0);
            this.tplControlbar.Location = new System.Drawing.Point(12, 12);
            this.tplControlbar.Name = "tplControlbar";
            this.tplControlbar.RowCount = 1;
            this.tplControlbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplControlbar.Size = new System.Drawing.Size(1896, 68);
            this.tplControlbar.TabIndex = 2;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteList.Location = new System.Drawing.Point(311, 3);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(148, 62);
            this.btnDeleteList.TabIndex = 3;
            this.btnDeleteList.Text = "Delete List";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookList.Location = new System.Drawing.Point(157, 3);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(148, 62);
            this.btnBookList.TabIndex = 2;
            this.btnBookList.Text = "Book";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(148, 62);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(1727, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblListName
            // 
            this.lblListName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListName.AutoSize = true;
            this.lblListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListName.Location = new System.Drawing.Point(13, 87);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(381, 76);
            this.lblListName.TabIndex = 3;
            this.lblListName.Text = "[List Name]";
            // 
            // lblListSize
            // 
            this.lblListSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListSize.AutoSize = true;
            this.lblListSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSize.Location = new System.Drawing.Point(378, 177);
            this.lblListSize.Name = "lblListSize";
            this.lblListSize.Size = new System.Drawing.Size(87, 25);
            this.lblListSize.TabIndex = 4;
            this.lblListSize.Text = "[#] Items";
            // 
            // lblListOwner
            // 
            this.lblListOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListOwner.AutoSize = true;
            this.lblListOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOwner.Location = new System.Drawing.Point(21, 177);
            this.lblListOwner.Name = "lblListOwner";
            this.lblListOwner.Size = new System.Drawing.Size(273, 25);
            this.lblListOwner.TabIndex = 5;
            this.lblListOwner.Text = "List Owner: [Section or Name]";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(569, 177);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(226, 25);
            this.lblCreationDate.TabIndex = 6;
            this.lblCreationDate.Text = "Created on: dd/mm/yyyy";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(901, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Booking: [Not made or dd/mm/yyyy - dd/mm/yyyy]";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbNotes.Enabled = false;
            this.rtbNotes.Location = new System.Drawing.Point(1351, 123);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(557, 79);
            this.rtbNotes.TabIndex = 8;
            this.rtbNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(1346, 95);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(98, 25);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "List Notes";
            // 
            // flpListItemScroll
            // 
            this.flpListItemScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListItemScroll.AutoScroll = true;
            this.flpListItemScroll.Location = new System.Drawing.Point(0, 243);
            this.flpListItemScroll.Name = "flpListItemScroll";
            this.flpListItemScroll.Size = new System.Drawing.Size(1920, 838);
            this.flpListItemScroll.TabIndex = 10;
            // 
            // EquipmentListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.flpListItemScroll);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblListOwner);
            this.Controls.Add(this.lblListSize);
            this.Controls.Add(this.lblListName);
            this.Controls.Add(this.tplControlbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarterMaster [List]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tplControlbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplControlbar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblListSize;
        private System.Windows.Forms.Label lblListOwner;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.FlowLayoutPanel flpListItemScroll;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnAddItem;
    }
}