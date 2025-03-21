﻿using petHealth.Models;
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
    public partial class frmObsJournal : Form
    {
        List<Pet> pets = new List<Pet>();
        public frmObsJournal()
        {
            InitializeComponent();

        }

        private void frmObsJournal_Load(object sender, EventArgs e)
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
        }
        private void SelectedPet(object sender, EventArgs e)
        {
            string selectedPet = cboPet.SelectedValue.ToString();
        }

        private bool PassedValidation()
        {
            //this.txtPetName.Text.Trim() == String.Empty 
            if (this.cboPet.Text.Trim() == String.Empty ||
                this.dtObs.Text.Trim() == String.Empty ||
                this.txtObservation.Text.Trim() == String.Empty)
                return false;
            else
                return true;
        }
        private void OpenHomeForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmHome());
        }
        private void OpenObsForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmObsJournal());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Name = cboPet.Text;
            string Dt = dtObs.Text;
            string Description = txtObservation.Text;
            string file = CurrentPath.GetDbasePath() + "\\" + "PetObservation.txt";

            if (!PassedValidation())
            {
                MessageBox.Show("Must enter information in all required fields!", "Observation Journal", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread th = new Thread(new ThreadStart(OpenObsForm));
                th.Start();
            }
            else
            {
                string dataToWrite = $"\n{Name}|{Dt}|{Description}";
                // Append to file
                System.IO.File.AppendAllText(file, dataToWrite);
                MessageBox.Show("Observation Added Sucessfully!", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(OpenHomeForm));
                t.Start();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenHomeForm));
            t.Start();
        }
    }
}
