using petHealth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHealth.Models
{
    public class userData
    {
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public userData()
        {

        }

        public List<userData> GetUser()
        {
            List<userData> user = new List<userData>();

            string file = CurrentPath.GetDbasePath() + "\\" + "userData.txt";

            user = ReadWriteTextFile.GetUserData(file);

            return user;
        }
    }
}

