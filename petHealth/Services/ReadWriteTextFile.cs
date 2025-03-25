using petHealth.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace petHealth.Services
{
    public static class ReadWriteTextFile
    {
        private static List<Pet> pets;
        private static List<PetObservation> petobservation;
        private static List<PetVaccination> petvaccination;
        private static List<PetAppointment> petappointment;
        private static List<userData> user;

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

        public static List<PetObservation> GetPetObservation(string file)
        {
            petobservation = new List<PetObservation>();
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
                            petobservation.Add(new PetObservation()
                            {
                                Name = data[0],
                                dt = DateTime.Parse(data[1]),
                                Observation = data[2]
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

            return petobservation;
        }
        public static List<PetVaccination> GetPetVaccination(string file)
        {
            petvaccination = new List<PetVaccination>();
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
                            petvaccination.Add(new PetVaccination()
                            {
                                Name = data[0],
                                dt = DateTime.Parse(data[1]),
                                Vaccination = data[2]
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

            return petvaccination;
        }
        public static List<PetAppointment> GetPetAppointment(string file)
        {
            petappointment = new List<PetAppointment>();
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
                            petappointment.Add(new PetAppointment()
                            {
                                Name = data[0],
                                dt = DateTime.Parse(data[1]),
                                Appointment = data[2]
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

            return petappointment;
        }
        public static List<userData> GetUserData(string file)
        {
            user = new List<userData>();
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
                            user.Add(new userData()
                            {
                                Email = data[0],
                                Phone = int.Parse(data[1]),
                                Username = data[3],
                                Password = data[4]
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

            return user;
        }
    }
}
