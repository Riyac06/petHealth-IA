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
    public partial class frmAppScheduler : Form
    {
        public frmAppScheduler()
        {
            InitializeComponent();
        }

        private void frmAppScheduler_Load(object sender, EventArgs e)
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
                Thread th = new Thread(new ThreadStart(OpenAppForm));
                th.Start();
            }
            else
            {
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(OpenHomeForm));
                t.Start();
            }
        }

        private bool PassedValidation()
        {
            if (this.cboPet.Text.Trim().Length == 0 ||
                this.dateTimePicker1.Text.Trim().Length == 0 ||
                this.txtDescription.Text.Trim().Length == 0 )
                return false;
            else
                return true;
        }

        private void OpenAppForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmAppScheduler());
        }
        private void OpenHomeForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmHome());
        }
    }
}
