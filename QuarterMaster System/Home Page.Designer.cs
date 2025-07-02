namespace QuarterMaster_System
{
    partial class HomePage
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
            this.picScoutLogo = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEquipmentList = new System.Windows.Forms.Button();
            this.btnEquipmentSearch = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScoutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picScoutLogo
            // 
            this.picScoutLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picScoutLogo.Image = global::QuarterMaster_System.Properties.Resources.Scouts_Australia_Logo;
            this.picScoutLogo.Location = new System.Drawing.Point(35, 23);
            this.picScoutLogo.Name = "picScoutLogo";
            this.picScoutLogo.Size = new System.Drawing.Size(220, 220);
            this.picScoutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScoutLogo.TabIndex = 1;
            this.picScoutLogo.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Led Italic Font", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(590, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(881, 139);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "QuarterMaster";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(850, 171);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(340, 37);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version: 1.00 Alpha 1a";
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(416, 674);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(508, 306);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Text = "Booking Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(1076, 674);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(508, 306);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnEquipmentList
            // 
            this.btnEquipmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquipmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipmentList.Location = new System.Drawing.Point(1076, 278);
            this.btnEquipmentList.Name = "btnEquipmentList";
            this.btnEquipmentList.Size = new System.Drawing.Size(508, 306);
            this.btnEquipmentList.TabIndex = 4;
            this.btnEquipmentList.Text = "Equipment Lists";
            this.btnEquipmentList.UseVisualStyleBackColor = true;
            // 
            // btnEquipmentSearch
            // 
            this.btnEquipmentSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipmentSearch.Location = new System.Drawing.Point(416, 278);
            this.btnEquipmentSearch.Name = "btnEquipmentSearch";
            this.btnEquipmentSearch.Size = new System.Drawing.Size(508, 306);
            this.btnEquipmentSearch.TabIndex = 0;
            this.btnEquipmentSearch.Text = "Search Equipment";
            this.btnEquipmentSearch.UseVisualStyleBackColor = true;
            this.btnEquipmentSearch.Click += new System.EventHandler(this.btnEquipmentSearch_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(1710, 981);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(198, 87);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnEquipmentList);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.picScoutLogo);
            this.Controls.Add(this.btnEquipmentSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarterMaster [Home Page]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picScoutLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picScoutLogo;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEquipmentList;
        private System.Windows.Forms.Button btnEquipmentSearch;
        private System.Windows.Forms.Button btnLogIn;
    }
}

