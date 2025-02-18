using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petHealth
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (!PassedValidation())
            {
                MessageBox.Show("Must enter information in all required fields!", "Pet Health", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread th = new Thread(new ThreadStart(OpenSignUpForm));
                th.Start();
            }
            else { 
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenLogInForm));
            t.Start();
                }
        }

        private bool PassedValidation()
        {
            if (this.txtUsername.Text.Trim().Length == 0 ||
                this.txtPass.Text.Trim().Length == 0 ||
                this.txtConfPass.Text.Trim().Length == 0 || 
                this.txtEmail.Text.Trim().Length == 0 ||
                this.txtPhoneNum.Text.Trim().Length == 0)
                return false;
            else
                return true;
        }

        private void OpenLogInForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmLogin());
        }
        private void OpenSignUpForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmSignUp());
        }
    }
}
