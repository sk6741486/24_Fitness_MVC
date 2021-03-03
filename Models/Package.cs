using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24_Fitness_MVC.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Package_Name { get; set; }
        public Decimal Package_Price { get; set; }
        public int Package_Duration { get; set; }
        public int Package_Condition { get; set; }
    }
}
