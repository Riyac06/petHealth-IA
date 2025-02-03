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
    public partial class loginPage : Form
    {
        public loginPage()
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

    }
}
