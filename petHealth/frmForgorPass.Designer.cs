namespace petHealth
{
    partial class frmForgorPass
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtEmailPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmailPhone = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Location = new System.Drawing.Point(307, 290);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(166, 52);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Enter!";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtEmailPhone
            // 
            this.txtEmailPhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPhone.Location = new System.Drawing.Point(231, 151);
            this.txtEmailPhone.Name = "txtEmailPhone";
            this.txtEmailPhone.Size = new System.Drawing.Size(313, 25);
            this.txtEmailPhone.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(231, 223);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(313, 25);
            this.txtUsername.TabIndex = 16;
            // 
            // lblEmailPhone
            // 
            this.lblEmailPhone.AutoSize = true;
            this.lblEmailPhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPhone.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEmailPhone.Location = new System.Drawing.Point(228, 121);
            this.lblEmailPhone.Name = "lblEmailPhone";
            this.lblEmailPhone.Size = new System.Drawing.Size(194, 18);
            this.lblEmailPhone.TabIndex = 15;
            this.lblEmailPhone.Text = "Email or Phone Number:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblUsername.Location = new System.Drawing.Point(228, 193);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 18);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username:";
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblForgotPass.Location = new System.Drawing.Point(309, 62);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(164, 24);
            this.lblForgotPass.TabIndex = 13;
            this.lblForgotPass.Text = "Forgot Password";
            // 
            // frmForgorPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEmailPhone);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmailPhone);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblForgotPass);
            this.Name = "frmForgorPass";
            this.Text = "ForgorPass";
            this.Load += new System.EventHandler(this.frmForgorPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtEmailPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmailPhone;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblForgotPass;
    }
}