namespace petHealth
{
    partial class frmPetProfiles
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
            this.btnAddPet = new System.Windows.Forms.Button();
            this.lblPetProfiles = new System.Windows.Forms.Label();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.lblObsJournal = new System.Windows.Forms.Label();
            this.lblVaxRecord = new System.Windows.Forms.Label();
            this.dgJournal = new System.Windows.Forms.DataGridView();
            this.dgVaccination = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccination)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPet
            // 
            this.btnAddPet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddPet.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddPet.Location = new System.Drawing.Point(601, 391);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(166, 36);
            this.btnAddPet.TabIndex = 21;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = false;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // lblPetProfiles
            // 
            this.lblPetProfiles.AutoSize = true;
            this.lblPetProfiles.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetProfiles.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPetProfiles.Location = new System.Drawing.Point(338, 44);
            this.lblPetProfiles.Name = "lblPetProfiles";
            this.lblPetProfiles.Size = new System.Drawing.Size(123, 24);
            this.lblPetProfiles.TabIndex = 17;
            this.lblPetProfiles.Text = "Pet Profiles";
            // 
            // cboPet
            // 
            this.cboPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(188, 83);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(160, 33);
            this.cboPet.TabIndex = 22;
            this.cboPet.SelectedValueChanged += new System.EventHandler(this.SelectedPet);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAge.Location = new System.Drawing.Point(354, 83);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 18);
            this.lblAge.TabIndex = 23;
            this.lblAge.Text = "Age:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWeight.Location = new System.Drawing.Point(418, 83);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 18);
            this.lblWeight.TabIndex = 24;
            this.lblWeight.Text = "Weight:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblBreed.Location = new System.Drawing.Point(509, 83);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(55, 18);
            this.lblBreed.TabIndex = 25;
            this.lblBreed.Text = "Breed:";
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.AutoSize = true;
            this.lblAboutMe.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMe.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAboutMe.Location = new System.Drawing.Point(354, 101);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(85, 18);
            this.lblAboutMe.TabIndex = 26;
            this.lblAboutMe.Text = "About Me:";
            // 
            // lblObsJournal
            // 
            this.lblObsJournal.AutoSize = true;
            this.lblObsJournal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsJournal.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblObsJournal.Location = new System.Drawing.Point(185, 139);
            this.lblObsJournal.Name = "lblObsJournal";
            this.lblObsJournal.Size = new System.Drawing.Size(202, 18);
            this.lblObsJournal.TabIndex = 27;
            this.lblObsJournal.Text = "Observation Journal Log: ";
            // 
            // lblVaxRecord
            // 
            this.lblVaxRecord.AutoSize = true;
            this.lblVaxRecord.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaxRecord.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblVaxRecord.Location = new System.Drawing.Point(185, 263);
            this.lblVaxRecord.Name = "lblVaxRecord";
            this.lblVaxRecord.Size = new System.Drawing.Size(163, 18);
            this.lblVaxRecord.TabIndex = 28;
            this.lblVaxRecord.Text = "Vaccination Record: ";
            // 
            // dgJournal
            // 
            this.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJournal.Location = new System.Drawing.Point(188, 160);
            this.dgJournal.Name = "dgJournal";
            this.dgJournal.Size = new System.Drawing.Size(376, 100);
            this.dgJournal.TabIndex = 29;
            // 
            // dgVaccination
            // 
            this.dgVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccination.Location = new System.Drawing.Point(188, 284);
            this.dgVaccination.Name = "dgVaccination";
            this.dgVaccination.Size = new System.Drawing.Size(376, 100);
            this.dgVaccination.TabIndex = 30;
            // 
            // frmPetProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVaccination);
            this.Controls.Add(this.dgJournal);
            this.Controls.Add(this.lblVaxRecord);
            this.Controls.Add(this.lblObsJournal);
            this.Controls.Add(this.lblAboutMe);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.lblPetProfiles);
            this.Name = "frmPetProfiles";
            this.Text = "Pet Profiles";
            this.Load += new System.EventHandler(this.frmPetProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Label lblPetProfiles;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblAboutMe;
        private System.Windows.Forms.Label lblObsJournal;
        private System.Windows.Forms.Label lblVaxRecord;
        private System.Windows.Forms.DataGridView dgJournal;
        private System.Windows.Forms.DataGridView dgVaccination;
    }
}