using petHealth.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Models
{
    public class PetObservation
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public string Observation { get; set; }

        public PetObservation()
        {

        }

        public List<PetObservation> GetPetObersvation()
        {
            List<PetObservation> petobservation = new List<PetObservation>();

            string file = CurrentPath.GetDbasePath() + "\\" + "PetObservationData.txt";

            petobservation = ReadWriteTextFile.GetPetObservation(file);

            return petobservation;
        }
    }
}
