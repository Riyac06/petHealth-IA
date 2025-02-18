namespace petHealth
{
    partial class frmAppScheduler
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAppSched = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.lblSelectPet = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblAppSched
            // 
            this.lblAppSched.AutoSize = true;
            this.lblAppSched.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSched.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAppSched.Location = new System.Drawing.Point(267, 62);
            this.lblAppSched.Name = "lblAppSched";
            this.lblAppSched.Size = new System.Drawing.Size(228, 24);
            this.lblAppSched.TabIndex = 14;
            this.lblAppSched.Text = "Appointment Scheduler";
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(255, 284);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(273, 25);
            this.txtObservation.TabIndex = 36;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDescription.Location = new System.Drawing.Point(252, 263);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 18);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description: ";
            // 
            // cboPet
            // 
            this.cboPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(308, 140);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(160, 33);
            this.cboPet.TabIndex = 34;
            // 
            // lblSelectPet
            // 
            this.lblSelectPet.AutoSize = true;
            this.lblSelectPet.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPet.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSelectPet.Location = new System.Drawing.Point(252, 119);
            this.lblSelectPet.Name = "lblSelectPet";
            this.lblSelectPet.Size = new System.Drawing.Size(91, 18);
            this.lblSelectPet.TabIndex = 37;
            this.lblSelectPet.Text = "Select Pet: ";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDT.Location = new System.Drawing.Point(252, 189);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(177, 18);
            this.lblDT.TabIndex = 38;
            this.lblDT.Text = "Select Date and Time: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(308, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 52);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "Submit!";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // frmAppScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblSelectPet);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.lblAppSched);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmAppScheduler";
            this.Text = "frmAppScheduler";
            this.Load += new System.EventHandler(this.frmAppScheduler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAppSched;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.Label lblSelectPet;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Button btnSubmit;
    }
}