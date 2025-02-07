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
            this.btnVaxRec = new System.Windows.Forms.Button();
            this.btnObsjour = new System.Windows.Forms.Button();
            this.btnPet1 = new System.Windows.Forms.Button();
            this.lblPetProfiles = new System.Windows.Forms.Label();
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
            // 
            // btnVaxRec
            // 
            this.btnVaxRec.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVaxRec.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaxRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVaxRec.Location = new System.Drawing.Point(317, 250);
            this.btnVaxRec.Name = "btnVaxRec";
            this.btnVaxRec.Size = new System.Drawing.Size(166, 72);
            this.btnVaxRec.TabIndex = 20;
            this.btnVaxRec.Text = "Vaccination Record";
            this.btnVaxRec.UseVisualStyleBackColor = false;
            // 
            // btnObsjour
            // 
            this.btnObsjour.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObsjour.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObsjour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObsjour.Location = new System.Drawing.Point(317, 172);
            this.btnObsjour.Name = "btnObsjour";
            this.btnObsjour.Size = new System.Drawing.Size(166, 72);
            this.btnObsjour.TabIndex = 19;
            this.btnObsjour.Text = "Observation Journal!";
            this.btnObsjour.UseVisualStyleBackColor = false;
            // 
            // btnPet1
            // 
            this.btnPet1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPet1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPet1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPet1.Location = new System.Drawing.Point(317, 92);
            this.btnPet1.Name = "btnPet1";
            this.btnPet1.Size = new System.Drawing.Size(166, 74);
            this.btnPet1.TabIndex = 18;
            this.btnPet1.Text = "Pet 1\'s name!";
            this.btnPet1.UseVisualStyleBackColor = false;
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
            // frmPetProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.btnVaxRec);
            this.Controls.Add(this.btnObsjour);
            this.Controls.Add(this.btnPet1);
            this.Controls.Add(this.lblPetProfiles);
            this.Name = "frmPetProfiles";
            this.Text = "frmPetProfiles";
            this.Load += new System.EventHandler(this.frmPetProfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnVaxRec;
        private System.Windows.Forms.Button btnObsjour;
        private System.Windows.Forms.Button btnPet1;
        private System.Windows.Forms.Label lblPetProfiles;
    }
}