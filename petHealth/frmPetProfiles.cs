using petHealth.Models;
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
        List<Pet> pets = new List<Pet>();

        public frmPetProfiles()
        {
            InitializeComponent();
        }

        private void frmPetProfiles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.GetPets();
            this.SetControls();
        }

        private void GetPets()
        {
            Pet petObj = new Pet();
            pets = petObj.GetPets();
        }

        private void SetControls()
        {

            if (pets.Count > 0)
            {
                this.cboPet.DataSource = pets;
                this.cboPet.DisplayMember = "Name";
                this.cboPet.ValueMember = "Name";
            }

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
