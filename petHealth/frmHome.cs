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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnpetProfiles_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenPetProfilesForm));
            t.Start();
        }

        private void OpenPetProfilesForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmPetProfiles());
        
    }

        private void btnObsjour_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenObsJournalForm));
            t.Start();
        }

        private void OpenObsJournalForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmObsJournal());

        }

        private void btnVaxRec_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenVaxRecordForm));
            t.Start();
        }

        private void OpenVaxRecordForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmVaxRecord());
        }

        private void btnApptSched_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenAppSchedulerForm));
            t.Start();
        }

        private void OpenAppSchedulerForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmAppScheduler());
        }
    }
}
