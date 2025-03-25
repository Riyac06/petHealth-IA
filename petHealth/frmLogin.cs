using petHealth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (AuthenticateUser())
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

        private bool AuthenticateUser()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Check for empty inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            // Get the path to userData.txt file
            string filePath = CurrentPath.GetDbasePath() + "\\" + "userData.txt";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("User data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                // Read all lines from the file
                string[] userLines = File.ReadAllLines(filePath);

                // Search for matching username
                foreach (string line in userLines)
                {
                    // Split the line by the pipe character
                    string[] userData = line.Split('|');

                    // Check if the line has the expected format (email|phone|username|password|)
                    // This means there should be at least 4 elements in the array
                    if (userData.Length >= 4)
                    {
                        string fileEmail = userData[0];
                        string filePhone = userData[1];
                        string fileUsername = userData[2];
                        string filePassword = userData[3];

                        // Check if username matches
                        if (fileUsername == username)
                        {
                            // Check if password matches
                            if (filePassword == password)
                            {
                                return true; // Authentication successful
                            }
                            else
                            {
                                return false; // Password doesn't match
                            }
                        }
                    }
                }

                // If we get here, no matching username was found
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading user data: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }
        */
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
