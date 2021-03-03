using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _24_Fitness_MVC.Models;

namespace _24_Fitness_MVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<_24_Fitness_MVC.Models.Package> Package { get; set; }

        public DbSet<_24_Fitness_MVC.Models.Trainer> Trainer { get; set; }

        public DbSet<_24_Fitness_MVC.Models.FitnessClub> FitnessClub { get; set; }

        public DbSet<_24_Fitness_MVC.Models.Activities> Activities { get; set; }

        public DbSet<_24_Fitness_MVC.Models.CenterDetail> CenterDetail { get; set; }
    }
}
