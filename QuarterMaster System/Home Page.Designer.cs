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
            this.picScoutLogo.Location = new System.Drawing.Point(147, 155);
            this.picScoutLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picScoutLogo.Name = "picScoutLogo";
            this.picScoutLogo.Size = new System.Drawing.Size(206, 229);
            this.picScoutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScoutLogo.TabIndex = 1;
            this.picScoutLogo.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Led Italic Font", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(787, 240);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblVersion.Location = new System.Drawing.Point(1066, 366);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(340, 37);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version: 1.00 Alpha 1a";
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(634, 995);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(476, 319);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Text = "Booking Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(1379, 995);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(476, 319);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnEquipmentList
            // 
            this.btnEquipmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquipmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipmentList.Location = new System.Drawing.Point(1379, 476);
            this.btnEquipmentList.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipmentList.Name = "btnEquipmentList";
            this.btnEquipmentList.Size = new System.Drawing.Size(476, 319);
            this.btnEquipmentList.TabIndex = 4;
            this.btnEquipmentList.Text = "Equipment Lists";
            this.btnEquipmentList.UseVisualStyleBackColor = true;
            this.btnEquipmentList.Click += new System.EventHandler(this.btnEquipmentList_Click);
            // 
            // btnEquipmentSearch
            // 
            this.btnEquipmentSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipmentSearch.Location = new System.Drawing.Point(634, 476);
            this.btnEquipmentSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipmentSearch.Name = "btnEquipmentSearch";
            this.btnEquipmentSearch.Size = new System.Drawing.Size(476, 319);
            this.btnEquipmentSearch.TabIndex = 0;
            this.btnEquipmentSearch.Text = "Search Equipment";
            this.btnEquipmentSearch.UseVisualStyleBackColor = true;
            this.btnEquipmentSearch.Click += new System.EventHandler(this.btnEquipmentSearch_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(2082, 1364);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(186, 90);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(2160, 1350);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnEquipmentList);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.picScoutLogo);
            this.Controls.Add(this.btnEquipmentSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarterMaster [Home Page]";
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

