using petHealth.Models;
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
    public partial class frmPetProfiles : Form
    {
        List<Pet> pets = new List<Pet>();
        List<PetObservation> petObservations = new List<PetObservation>();

        public frmPetProfiles()
        {
            InitializeComponent();
        }

        private void frmPetProfiles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //Pet Info
            this.GetPets();
            this.GetObservations();
            this.PetVaccinations();

            this.SetControls();
        }

        private void PetVaccinations()
        {
            throw new NotImplementedException();
        }

        private void GetObservations()
        {
            PetObservation observation = new PetObservation();
            petObservations = observation.GetPetObersvation();
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

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenAddPetForm));
            t.Start();
        }

        private void OpenAddPetForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmAddPet());
        }

        private void SelectedPet(object sender, EventArgs e)
        {
            //LINQ
            var selected = (from p in pets
                           where p.Name == cboPet.SelectedValue.ToString()
                           select new 
                           { 
                                Name = p.Name, 
                                Age = p.Age,
                                Weight = p.Weight,
                                Breed = p.Breed,
                                AboutMe = p.AboutMe
                           }).ToList();

            if (selected.Count > 0)
            {
                this.lblAge.Text = "Age: " + selected[0].Age;
                this.lblWeight.Text = "Weight: " + selected[0].Weight;
                this.lblBreed.Text = "Breed: " + selected[0].Breed;
                this.lblAboutMe.Text = "About Me: " + selected[0].AboutMe;

                //Observations
                var petobserving = (from po in petObservations
                                    where po.Name == cboPet.SelectedValue.ToString()
                                    select po).ToList();

                this.dgJournal.DataSource = petobserving;

                //Vaccinations
                var petVaccinations = (from v in petObservations
                                    where v.Name == cboPet.SelectedValue.ToString()
                                    select v).ToList();

                this.dgVaccination.DataSource = petVaccinations;

            }
        }
    }
 }
