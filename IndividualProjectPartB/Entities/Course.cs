using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = IndividualProjectPartB.Enums.Type;

namespace IndividualProjectPartB.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public Type Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

        public Course()
        {
            Students = new HashSet<Student>();
            Trainers = new HashSet<Trainer>();
            Assignments = new HashSet<Assignment>();
        }

    }
}
