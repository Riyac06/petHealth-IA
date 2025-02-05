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
    public partial class frmResetPass : Form
    {
        public frmResetPass()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenLoginForm));
            t.Start();
        }

        private void OpenLoginForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmLogin());
        }

        private void frmResetPass_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
