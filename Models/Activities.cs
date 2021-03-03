using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24_Fitness_MVC.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public Decimal Activity_Price { get; set; }
        public DateTime Time_Duration { get; set; }
        public int Trainer_Id { get; set; }


    }
}
