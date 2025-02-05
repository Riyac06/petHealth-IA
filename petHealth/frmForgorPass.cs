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
    public partial class frmForgorPass : Form
    {
        public frmForgorPass()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenResetPassForm));
            t.Start();
        }

        private void OpenResetPassForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmResetPass());
        }

        private void frmForgorPass_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
