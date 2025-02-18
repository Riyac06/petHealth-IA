namespace petHealth
{
    partial class frmVaxRecord
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblSelectPet = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblVaxName = new System.Windows.Forms.Label();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRecordVax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(318, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 52);
            this.btnSubmit.TabIndex = 46;
            this.btnSubmit.Text = "Submit!";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDT.Location = new System.Drawing.Point(260, 160);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(177, 18);
            this.lblDT.TabIndex = 45;
            this.lblDT.Text = "Select Date and Time: ";
            // 
            // lblSelectPet
            // 
            this.lblSelectPet.AutoSize = true;
            this.lblSelectPet.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPet.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSelectPet.Location = new System.Drawing.Point(260, 90);
            this.lblSelectPet.Name = "lblSelectPet";
            this.lblSelectPet.Size = new System.Drawing.Size(91, 18);
            this.lblSelectPet.TabIndex = 44;
            this.lblSelectPet.Text = "Select Pet: ";
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(263, 255);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(273, 25);
            this.txtObservation.TabIndex = 43;
            // 
            // lblVaxName
            // 
            this.lblVaxName.AutoSize = true;
            this.lblVaxName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaxName.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblVaxName.Location = new System.Drawing.Point(260, 234);
            this.lblVaxName.Name = "lblVaxName";
            this.lblVaxName.Size = new System.Drawing.Size(105, 18);
            this.lblVaxName.TabIndex = 42;
            this.lblVaxName.Text = "Description: ";
            // 
            // cboPet
            // 
            this.cboPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(316, 111);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(160, 33);
            this.cboPet.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // lblRecordVax
            // 
            this.lblRecordVax.AutoSize = true;
            this.lblRecordVax.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordVax.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblRecordVax.Location = new System.Drawing.Point(294, 34);
            this.lblRecordVax.Name = "lblRecordVax";
            this.lblRecordVax.Size = new System.Drawing.Size(200, 24);
            this.lblRecordVax.TabIndex = 47;
            this.lblRecordVax.Text = "Record Vaccination ";
            // 
            // frmVaxRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecordVax);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblSelectPet);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblVaxName);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmVaxRecord";
            this.Text = "frmVaxRecord";
            this.Load += new System.EventHandler(this.frmVaxRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblSelectPet;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblVaxName;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblRecordVax;
    }
}