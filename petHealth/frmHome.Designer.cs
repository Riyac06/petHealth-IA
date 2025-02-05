namespace petHealth
{
    partial class frmHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnpetProfiles = new System.Windows.Forms.Button();
            this.btnObsjour = new System.Windows.Forms.Button();
            this.btnVaxRec = new System.Windows.Forms.Button();
            this.btnApptSched = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWelcome.Location = new System.Drawing.Point(333, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(99, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnpetProfiles
            // 
            this.btnpetProfiles.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnpetProfiles.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpetProfiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpetProfiles.Location = new System.Drawing.Point(302, 94);
            this.btnpetProfiles.Name = "btnpetProfiles";
            this.btnpetProfiles.Size = new System.Drawing.Size(166, 74);
            this.btnpetProfiles.TabIndex = 13;
            this.btnpetProfiles.Text = "Pet Profiles!";
            this.btnpetProfiles.UseVisualStyleBackColor = false;
            this.btnpetProfiles.Click += new System.EventHandler(this.btnpetProfiles_Click);
            // 
            // btnObsjour
            // 
            this.btnObsjour.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObsjour.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObsjour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObsjour.Location = new System.Drawing.Point(302, 174);
            this.btnObsjour.Name = "btnObsjour";
            this.btnObsjour.Size = new System.Drawing.Size(166, 72);
            this.btnObsjour.TabIndex = 14;
            this.btnObsjour.Text = "Observation Journal!";
            this.btnObsjour.UseVisualStyleBackColor = false;
            this.btnObsjour.Click += new System.EventHandler(this.btnObsjour_Click);
            // 
            // btnVaxRec
            // 
            this.btnVaxRec.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVaxRec.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaxRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVaxRec.Location = new System.Drawing.Point(302, 252);
            this.btnVaxRec.Name = "btnVaxRec";
            this.btnVaxRec.Size = new System.Drawing.Size(166, 72);
            this.btnVaxRec.TabIndex = 15;
            this.btnVaxRec.Text = "Vaccination Record";
            this.btnVaxRec.UseVisualStyleBackColor = false;
            this.btnVaxRec.Click += new System.EventHandler(this.btnVaxRec_Click);
            // 
            // btnApptSched
            // 
            this.btnApptSched.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnApptSched.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptSched.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApptSched.Location = new System.Drawing.Point(302, 330);
            this.btnApptSched.Name = "btnApptSched";
            this.btnApptSched.Size = new System.Drawing.Size(166, 74);
            this.btnApptSched.TabIndex = 16;
            this.btnApptSched.Text = "Appointment Scheduler";
            this.btnApptSched.UseVisualStyleBackColor = false;
            this.btnApptSched.Click += new System.EventHandler(this.btnApptSched_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApptSched);
            this.Controls.Add(this.btnVaxRec);
            this.Controls.Add(this.btnObsjour);
            this.Controls.Add(this.btnpetProfiles);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnpetProfiles;
        private System.Windows.Forms.Button btnObsjour;
        private System.Windows.Forms.Button btnVaxRec;
        private System.Windows.Forms.Button btnApptSched;
    }
}