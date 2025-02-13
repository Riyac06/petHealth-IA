using petHealth.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Services
{
    public static class ReadWriteTextFile
    {
        private static List<Pet> pets;

        public static List<Pet> GetPetData(string file)
        {
            pets = new List<Pet>();
            string line = string.Empty;

            try
            {
                //Check if the file exists
                if (File.Exists(file))
                {
                    //Create a Stream Reader
                    using (StreamReader rdr = new StreamReader(file))
                    {
                        //Read the data in the file
                        while ((line = rdr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');

                            //Add data to the Customers Model
                            pets.Add(new Pet()
                            {
                                Name = data[0],
                                Age = int.Parse(data[1]),
                                Weight = double.Parse(data[2]),
                                Breed = data[3],
                                AboutMe = data[4]
                            });

                        }
                    }
                }
                else
                {
                    throw new Exception("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pets;
        }

        public static bool ExportDataToTextFile(List<Pet> data, string file)
        {
            try
            {
                //We want to 
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        writer.WriteLine(d.Name.ToString() + "\\" + d.Age.ToString() + "\\" + 
                                         d.Weight.ToString() + "\\" + d.Breed.ToString() + "\\" +
                                         d.AboutMe.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
