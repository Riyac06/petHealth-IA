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
    public partial class frmAddPet : Form
    {
        public frmAddPet()
        {
            InitializeComponent();
        }
        /*
        private void loginPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void frmForgorPass_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        */
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (!PassedValidation())
            {
                MessageBox.Show("Must enter information in all required fields!", "Pet Health", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread th = new Thread(new ThreadStart(OpenAddPetForm));
                th.Start();
            }
            else
            {
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(OpenPetProfilesForm));
                t.Start();
            }
        }

        private void OpenPetProfilesForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmPetProfiles());
        }

        private void OpenAddPetForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmAddPet());
        }

        private void frmAddPet_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private bool PassedValidation()
        {
            if (this.txtPetName.Text.Trim() == String.Empty ||
                this.txtAge.Text.Trim() == String.Empty ||
                this.txtWeight.Text.Trim() == String.Empty ||
                this.txtBreed.Text.Trim() == String.Empty ||
                this.txtAbtMe.Text.Trim() == String.Empty)
                return false;
            else
                return true;
            }

            // this.AddData();
        }

        /* 
        private void AddData()
        {
            if (FindDuplicates())
                return;

            PetData.Add(new PersonsModel()
            {
                Person = this.txtData.Text.Trim()
            });

            this.AddToList();
        }

        private void AddToList()
        {
            //LINQ - Get Person Field Data from ArrayList
            var results = (from d in data
                           select d.Person).ToList();

            this.lstData.DataSource = results;
        }

        private bool FindDuplicates()
        {
            string msg = this.txtData.Text.Trim() + " already exists!";

            var duplicates = data.Where(x => x.Person == this.txtData.Text.Trim()).ToList();

            if (duplicates.Count > 0)
            {
                MessageBox.Show(this, msg, TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = this.lstData.SelectedValue;

            data.RemoveAll(x => x.Person == value.ToString());

            this.AddToList();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var results = (from d in data
                           select d.Person).ToList();

            if (results.Count == 0)
            {
                MessageBox.Show(this, "There is no data to export!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmExport export = new frmExport();
            export.Data = data;
            export.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */
    }
    
