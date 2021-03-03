using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24_Fitness_MVC.Models
{
    public class FitnessClub
    {
        public int Id { get; set; }
        public string Club_Name { get; set; }
        public string Club_Email { get; set; }
        public string Club_Phone { get; set; }
        public string Gender_Type { get; set; }
        public string Package_Id { get; set; }
    }
}
