using petHealth.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Models
{
    public class PetVaccination
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public string Vaccination { get; set; }

        public PetVaccination()
        {

        }

        public List<PetVaccination> GetPetVaccination()
        {
            List<PetVaccination> petvaccination = new List<PetVaccination>();

            string file = CurrentPath.GetDbasePath() + "\\" + "PetVaccination.txt";

            petvaccination = ReadWriteTextFile.GetPetVaccination(file);

            return petvaccination;
        }
    }
}