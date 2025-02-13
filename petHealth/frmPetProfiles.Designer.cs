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
            this.cboPet.Location = new System.Drawing.Point(318, 88);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(160, 33);
            this.cboPet.TabIndex = 22;
            // 
            // frmPetProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.lblPetProfiles);
            this.Name = "frmPetProfiles";
            this.Text = "frmPetProfiles";
            this.Load += new System.EventHandler(this.frmPetProfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Label lblPetProfiles;
        private System.Windows.Forms.ComboBox cboPet;
    }
}