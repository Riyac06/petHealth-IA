using petHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth
{
    public class AppointmentManager
    {
        private List<PetAppointment> petAppointments;

        public AppointmentManager(List<PetAppointment> appointments)
        {
            petAppointments = appointments;
        }

        public PetAppointment GetUpcomingAppointment(string selectedPet)
        {
            var currentDateTime = DateTime.Now;

            return petAppointments
                .Where(pa => pa.Name == selectedPet && pa.dt > currentDateTime)
                .OrderBy(pa => pa.dt)
                .FirstOrDefault();
        }

        public string GetAppointmentDisplay(string selectedPet)
        {
            var upcomingAppointment = GetUpcomingAppointment(selectedPet);

            if (upcomingAppointment != null)
            {
                return $"Upcoming appointment for {upcomingAppointment.Name}:\n" +
                       $"Appointment: {upcomingAppointment.Appointment}\n" +
                       $"Date: {upcomingAppointment.dt}";
            }
            else
            {
                return "No upcoming appointments.";
            }
        }
    }
}
