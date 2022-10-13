using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.AssignmentView
{
    public class InputAssignment
    {
        public Assignment GetNewAssignmentData()
        {
            Console.WriteLine("Title");
            string title = Console.ReadLine();
            Console.WriteLine("Description");
            string description = Console.ReadLine();
            Console.WriteLine("Submission Date");
            DateTime submit = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Oral Mark");
            int omark = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Mark");
            int tmark = int.Parse(Console.ReadLine());
            return new Assignment() { Title = title, Description = description, SubmissionDate = submit, OralMark = omark, TotalMark = tmark };
        }
    }
}
