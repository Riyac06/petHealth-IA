using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Breed { get; set; }
        public string AboutMe { get; set; }

        public Pet()
        {

        }

        public List<Pet> GetPets()
        {
            List<Pet> pets = new List<Pet>();

            string file = CurrentPath.GetDbasePath() + "\\" + "PetData";
            

            return pets; 
        }
    }
}
