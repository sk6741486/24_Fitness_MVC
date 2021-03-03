using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24_Fitness_MVC.Models
{
    public class CenterDetail
    {
        public int Id { get; set; }
        public string CenterName { get; set; }
        public int Club_Id { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public DateTime Open_Hours { get; set; }
        public string Activitie { get; set; }

    }
}
