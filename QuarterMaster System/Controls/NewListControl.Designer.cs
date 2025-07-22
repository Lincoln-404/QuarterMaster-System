namespace QuarterMaster_System
{
    partial class NewListControl
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
            this.lblCreateNewList = new System.Windows.Forms.Label();
            this.lblListName = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.lblListOwner = new System.Windows.Forms.Label();
            this.txtListOwner = new System.Windows.Forms.TextBox();
            this.lblListNotes = new System.Windows.Forms.Label();
            this.rtbListNotes = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateNewList
            // 
            this.lblCreateNewList.AutoSize = true;
            this.lblCreateNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewList.Location = new System.Drawing.Point(93, 13);
            this.lblCreateNewList.Name = "lblCreateNewList";
            this.lblCreateNewList.Size = new System.Drawing.Size(395, 58);
            this.lblCreateNewList.TabIndex = 0;
            this.lblCreateNewList.Text = "Create New List";
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListName.Location = new System.Drawing.Point(32, 108);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(127, 29);
            this.lblListName.TabIndex = 1;
            this.lblListName.Text = "List Name:";
            // 
            // txtListName
            // 
            this.txtListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtListName.Location = new System.Drawing.Point(174, 107);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(351, 30);
            this.txtListName.TabIndex = 2;
            this.txtListName.Text = "Spring Camp 2020";
            this.txtListName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtListName_MouseClick);
            this.txtListName.Leave += new System.EventHandler(this.txtListName_Leave);
            // 
            // lblListOwner
            // 
            this.lblListOwner.AutoSize = true;
            this.lblListOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOwner.Location = new System.Drawing.Point(32, 182);
            this.lblListOwner.Name = "lblListOwner";
            this.lblListOwner.Size = new System.Drawing.Size(134, 29);
            this.lblListOwner.TabIndex = 3;
            this.lblListOwner.Text = "List Owner:";
            // 
            // txtListOwner
            // 
            this.txtListOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListOwner.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtListOwner.Location = new System.Drawing.Point(174, 182);
            this.txtListOwner.Name = "txtListOwner";
            this.txtListOwner.Size = new System.Drawing.Size(351, 30);
            this.txtListOwner.TabIndex = 4;
            this.txtListOwner.Text = "Section or Name";
            this.txtListOwner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtListOwner_MouseClick);
            this.txtListOwner.Leave += new System.EventHandler(this.txtListOwner_Leave);
            // 
            // lblListNotes
            // 
            this.lblListNotes.AutoSize = true;
            this.lblListNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListNotes.Location = new System.Drawing.Point(32, 263);
            this.lblListNotes.Name = "lblListNotes";
            this.lblListNotes.Size = new System.Drawing.Size(126, 29);
            this.lblListNotes.TabIndex = 5;
            this.lblListNotes.Text = "List Notes:";
            // 
            // rtbListNotes
            // 
            this.rtbListNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbListNotes.Location = new System.Drawing.Point(174, 270);
            this.rtbListNotes.Name = "rtbListNotes";
            this.rtbListNotes.Size = new System.Drawing.Size(351, 159);
            this.rtbListNotes.TabIndex = 6;
            this.rtbListNotes.Text = "Optional";
            this.rtbListNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbListNotes_MouseClick);
            this.rtbListNotes.Leave += new System.EventHandler(this.rtbListNotes_Leave);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(16, 456);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(569, 104);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(506, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rtbListNotes);
            this.Controls.Add(this.lblListNotes);
            this.Controls.Add(this.txtListOwner);
            this.Controls.Add(this.lblListOwner);
            this.Controls.Add(this.txtListName);
            this.Controls.Add(this.lblListName);
            this.Controls.Add(this.lblCreateNewList);
            this.Name = "NewListControl";
            this.Size = new System.Drawing.Size(600, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateNewList;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label lblListOwner;
        private System.Windows.Forms.TextBox txtListOwner;
        private System.Windows.Forms.Label lblListNotes;
        private System.Windows.Forms.RichTextBox rtbListNotes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
