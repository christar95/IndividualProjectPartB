using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }

        public Assignment()
        {
            Students = new HashSet<Student>();
        }

    }
}
