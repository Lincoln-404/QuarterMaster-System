namespace QuarterMaster_System
{
    partial class NewBoookingControl
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
            this.lblNewBooking = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.dtpStartDagte = new System.Windows.Forms.DateTimePicker();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookedBy = new System.Windows.Forms.Label();
            this.txtBookedBy = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewBooking
            // 
            this.lblNewBooking.AutoSize = true;
            this.lblNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBooking.Location = new System.Drawing.Point(65, 25);
            this.lblNewBooking.Name = "lblNewBooking";
            this.lblNewBooking.Size = new System.Drawing.Size(482, 85);
            this.lblNewBooking.TabIndex = 0;
            this.lblNewBooking.Text = "New Booking";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(115, 171);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(76, 32);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "Item:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(209, 171);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(269, 32);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Select";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingDate.Location = new System.Drawing.Point(3, 240);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(188, 32);
            this.lblStartingDate.TabIndex = 3;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // dtpStartDagte
            // 
            this.dtpStartDagte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDagte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDagte.Location = new System.Drawing.Point(232, 240);
            this.dtpStartDagte.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpStartDagte.Name = "dtpStartDagte";
            this.dtpStartDagte.Size = new System.Drawing.Size(184, 35);
            this.dtpStartDagte.TabIndex = 4;
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingDate.Location = new System.Drawing.Point(12, 333);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(179, 32);
            this.lblEndingDate.TabIndex = 5;
            this.lblEndingDate.Text = "Ending Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(232, 333);
            this.dtpEndDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(184, 35);
            this.dtpEndDate.TabIndex = 6;
            // 
            // lblBookedBy
            // 
            this.lblBookedBy.AutoSize = true;
            this.lblBookedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedBy.Location = new System.Drawing.Point(35, 427);
            this.lblBookedBy.Name = "lblBookedBy";
            this.lblBookedBy.Size = new System.Drawing.Size(156, 32);
            this.lblBookedBy.TabIndex = 7;
            this.lblBookedBy.Text = "Booked by:";
            // 
            // txtBookedBy
            // 
            this.txtBookedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBookedBy.Location = new System.Drawing.Point(209, 424);
            this.txtBookedBy.Name = "txtBookedBy";
            this.txtBookedBy.Size = new System.Drawing.Size(280, 35);
            this.txtBookedBy.TabIndex = 8;
            this.txtBookedBy.Text = "Section or Name";
            this.txtBookedBy.Click += new System.EventHandler(this.txtBookedBy_Click);
            this.txtBookedBy.Leave += new System.EventHandler(this.txtBookedBy_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(95, 531);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(96, 32);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNotes.Location = new System.Drawing.Point(209, 531);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(280, 35);
            this.txtNotes.TabIndex = 10;
            this.txtNotes.Text = "Optional";
            this.txtNotes.Click += new System.EventHandler(this.txtNotes_Click);
            this.txtNotes.Leave += new System.EventHandler(this.txtNotes_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 646);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 55);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 646);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 55);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewBoookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtBookedBy);
            this.Controls.Add(this.lblBookedBy);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.dtpStartDagte);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblNewBooking);
            this.Name = "NewBoookingControl";
            this.Size = new System.Drawing.Size(612, 727);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewBooking;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.DateTimePicker dtpStartDagte;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblBookedBy;
        private System.Windows.Forms.TextBox txtBookedBy;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
