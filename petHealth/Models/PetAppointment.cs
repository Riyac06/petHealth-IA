using petHealth.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Models
{
    public class PetAppointment
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public string Appointment { get; set; }

        public PetAppointment()
        {

        }

        public List<PetAppointment> GetPetAppointment()
        {
            List<PetAppointment> petappointment = new List<PetAppointment>();

            string file = CurrentPath.GetDbasePath() + "\\" + "PetAppointment.txt";

            petappointment = ReadWriteTextFile.GetPetAppointment(file);

            return petappointment;
        }
    }
}