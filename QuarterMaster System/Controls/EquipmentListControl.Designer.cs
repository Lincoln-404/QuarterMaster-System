namespace QuarterMaster_System.Controls
{
    partial class EquipmentListControl
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
            this.lblListName = new System.Windows.Forms.Label();
            this.lblListBooking = new System.Windows.Forms.Label();
            this.lblListOwner = new System.Windows.Forms.Label();
            this.lblListSize = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListName.Location = new System.Drawing.Point(13, 15);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(232, 46);
            this.lblListName.TabIndex = 0;
            this.lblListName.Text = "[List Name]";
            // 
            // lblListBooking
            // 
            this.lblListBooking.AutoSize = true;
            this.lblListBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBooking.Location = new System.Drawing.Point(17, 204);
            this.lblListBooking.Name = "lblListBooking";
            this.lblListBooking.Size = new System.Drawing.Size(447, 25);
            this.lblListBooking.TabIndex = 1;
            this.lblListBooking.Text = "Booking: [Not Made or dd/mm/yyyy - dd/mm/yyyy]";
            // 
            // lblListOwner
            // 
            this.lblListOwner.AutoSize = true;
            this.lblListOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOwner.Location = new System.Drawing.Point(17, 144);
            this.lblListOwner.Name = "lblListOwner";
            this.lblListOwner.Size = new System.Drawing.Size(273, 25);
            this.lblListOwner.TabIndex = 2;
            this.lblListOwner.Text = "List Owner: [Section or Name]";
            // 
            // lblListSize
            // 
            this.lblListSize.AutoSize = true;
            this.lblListSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSize.Location = new System.Drawing.Point(17, 83);
            this.lblListSize.Name = "lblListSize";
            this.lblListSize.Size = new System.Drawing.Size(87, 25);
            this.lblListSize.TabIndex = 3;
            this.lblListSize.Text = "[#] Items";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(573, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(124, 57);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(573, 107);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(124, 57);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Book";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(573, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 57);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EquipmentListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblListSize);
            this.Controls.Add(this.lblListOwner);
            this.Controls.Add(this.lblListBooking);
            this.Controls.Add(this.lblListName);
            this.Name = "EquipmentListControl";
            this.Size = new System.Drawing.Size(700, 266);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblListBooking;
        private System.Windows.Forms.Label lblListOwner;
        private System.Windows.Forms.Label lblListSize;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnDelete;
    }
}
