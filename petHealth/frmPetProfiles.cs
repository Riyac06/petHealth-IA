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
        List<PetAppointment> petAppointments = new List<PetAppointment>();
        List<PetObservation> petObservations = new List<PetObservation>();
        List<PetVaccination> petVaccinations = new List<PetVaccination>();

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
            this.GetVaccinations();
            this.GetAppointments();
            this.SetControls();
        }

        private void GetVaccinations()
        {
            PetVaccination vaccination = new PetVaccination();
            petVaccinations = vaccination.GetPetVaccination();
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

        private void GetAppointments()
        {
            PetAppointment appointment = new PetAppointment();
            petAppointments = appointment.GetPetAppointment();
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
            //Clear out the DataGridViews
            this.dgJournal.DataSource = null;
            this.dgVaccination.DataSource = null;

            string selectedPet = cboPet.SelectedValue.ToString();

            //LINQ
            var selected = (from p in pets
                           where p.Name == selectedPet
                           select new 
                           { 
                                Name = p.Name, 
                                Age = p.Age,
                                Weight = p.Weight,
                                Breed = p.Breed,
                                AboutMe = p.AboutMe
                           }).ToList();
            // LINQ for appointment 

            var selectedA = (from pa in petAppointments
                             where pa.Name == selectedPet
                            select new
                            {
                                Name = pa.Name,
                                DateTime = pa.dt,
                                Appointment = pa.Appointment
                            }).ToList();

            if (selected.Count > 0)
            {
                this.lblAge.Text = "Age: " + selected[0].Age;
                this.lblWeight.Text = "Weight: " + selected[0].Weight;
                this.lblBreed.Text = "Breed: " + selected[0].Breed;
                this.lblAboutMe.Text = "About Me: " + selected[0].AboutMe;
                
                // Currently it is index out of range 
                this.lblNextAppointment.Text = "Next Appointment: " + selectedA[0].DateTime.ToString() + " " + selectedA[0].Appointment;

                //Observations
                var petobserving = (from po in petObservations
                                    where po.Name == selectedPet
                                    select po).ToList();

                this.dgJournal.DataSource = petobserving;

                //Vaccinations
                var petvaccinations = (from pv in petVaccinations
                                       where pv.Name == selectedPet
                                       select pv).ToList();

                this.dgVaccination.DataSource = petvaccinations;

            }
        }
    }
 }
