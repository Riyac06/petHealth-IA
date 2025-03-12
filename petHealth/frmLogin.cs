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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace petHealth
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void goSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenSignUpForm));
            t.Start();
        }

        private void OpenSignUpForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmSignUp());
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(OpenHomeForm));
                t.Start();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful!", "Try Again", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool AuthenticateUser(string username, string password)
        {
            return true;
            //return username == "exampleUser" && password == "password123";
        }

        private void OpenHomeForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmHome());
        }

        private void goForgorPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenForgorPassForm));
            t.Start();
        }

        private void OpenForgorPassForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmForgorPass());
        }
    }
}
