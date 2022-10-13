using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        public ICollection<Assignment> Assignments { get; set; } 
        public ICollection<Course> Courses { get; set; }

        public Student()
        {
            Assignments = new HashSet<Assignment>();
            Courses = new HashSet<Course>();
        }

    }
}
