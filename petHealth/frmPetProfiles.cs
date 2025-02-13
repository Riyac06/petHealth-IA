using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petHealth
{
    public partial class frmPetProfiles : Form
    {
        public frmPetProfiles()
        {
            InitializeComponent();
        }

        private void frmPetProfiles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            if (this.cboPet.Items.Count == 0)
            {
                this.btnAddPet.Enabled = false;
                this.btnObsjour.Enabled = false;
                this.btnVaxRec.Enabled = false;
            }
            else
            {
                this.btnAddPet.Enabled = true;
                this.btnObsjour.Enabled = true;
                this.btnVaxRec.Enabled = true;
            }
        }

        private void btnPet1_Click(object sender, EventArgs e)
        {

        }

        private void btnObsjour_Click(object sender, EventArgs e)
        {

        }

        private void btnVaxRec_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {

        }
    }
}
