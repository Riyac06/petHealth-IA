using petHealth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace petHealth
{
    public partial class frmLogin : Form
    {
        List<userData> users = new List<userData>();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.GetUser();
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

        private void GetUser()
        {
            userData user = new userData();
            users = user.GetUser();
        }

        private bool AuthenticateUser(string username, string password)
        {
            string file = CurrentPath.GetDbasePath() + "\\" + "userData.txt";
            string hashedPassword = HashPassword(password);
            string user = txtUsername.ToString();
            //LINQ
            var selected = (from u in users
                            where u.Username == user
                            select new
                            {
                                Email = u.Email,
                                Phone = u.Phone,
                                Username = u.Username,
                                Password = u.Password,
                            }).ToList();

            if (this.txtUsername.Text.Trim() == String.Empty ||
                this.txtPassword.Text.Trim() == String.Empty)
                return false;
            else if (username == selected[0].Username && hashedPassword == selected[0].Password)
                {
                    return true;
                }
            else
            {
                return false;
            }
            
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedBytes);
            }
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
