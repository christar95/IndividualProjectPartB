using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IndividualProjectPartB.Entities;

namespace IndividualProjectPartB.MyDatabase
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Sindesmos")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
    }
}
