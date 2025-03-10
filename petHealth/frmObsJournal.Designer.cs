namespace petHealth
{
    partial class frmObsJournal
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
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblEnterObs = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSelectPet = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.dtObs = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblForgotPass.Location = new System.Drawing.Point(296, 55);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(199, 24);
            this.lblForgotPass.TabIndex = 14;
            this.lblForgotPass.Text = "Observation Journal";
            // 
            // cboPet
            // 
            this.cboPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(306, 134);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(160, 33);
            this.cboPet.TabIndex = 23;
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(230, 279);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(313, 25);
            this.txtObservation.TabIndex = 33;
            // 
            // lblEnterObs
            // 
            this.lblEnterObs.AutoSize = true;
            this.lblEnterObs.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterObs.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEnterObs.Location = new System.Drawing.Point(227, 258);
            this.lblEnterObs.Name = "lblEnterObs";
            this.lblEnterObs.Size = new System.Drawing.Size(154, 18);
            this.lblEnterObs.TabIndex = 32;
            this.lblEnterObs.Text = "Enter Observation: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(300, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 52);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit!";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSelectPet
            // 
            this.lblSelectPet.AutoSize = true;
            this.lblSelectPet.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPet.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSelectPet.Location = new System.Drawing.Point(227, 113);
            this.lblSelectPet.Name = "lblSelectPet";
            this.lblSelectPet.Size = new System.Drawing.Size(91, 18);
            this.lblSelectPet.TabIndex = 35;
            this.lblSelectPet.Text = "Select Pet: ";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDT.Location = new System.Drawing.Point(227, 187);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(177, 18);
            this.lblDT.TabIndex = 47;
            this.lblDT.Text = "Select Date and Time: ";
            // 
            // dtObs
            // 
            this.dtObs.Location = new System.Drawing.Point(280, 220);
            this.dtObs.Name = "dtObs";
            this.dtObs.Size = new System.Drawing.Size(200, 20);
            this.dtObs.TabIndex = 46;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(569, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 36);
            this.btnHome.TabIndex = 49;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmObsJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.dtObs);
            this.Controls.Add(this.lblSelectPet);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblEnterObs);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.lblForgotPass);
            this.Name = "frmObsJournal";
            this.Text = "frmObsJournal";
            this.Load += new System.EventHandler(this.frmObsJournal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblEnterObs;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSelectPet;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.DateTimePicker dtObs;
        private System.Windows.Forms.Button btnHome;
    }
}