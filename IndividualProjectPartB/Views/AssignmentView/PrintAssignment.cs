using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.AssignmentView
{
    public class PrintAssignment
    {
        public static void Print(Assignment assignment)
        {
            Console.WriteLine($"{"Id",-5}{"Title",-15}{"Description",-15}{"Submission Date",-15}{"Oral Mark",-15}{"Total Mark",-15}");
            Console.WriteLine($"{assignment.Id,-5}{assignment.Title,-15}{assignment.Description,-15}{assignment.SubmissionDate,-15}{assignment.OralMark}{assignment.TotalMark}");

        }

        public static void PrintAll(List<Assignment> assignments)
        {
            Console.WriteLine($"{"Id",-5}{"Title",-15}{"Description",-15}{"Submission Date",-15}{"Oral Mark",-15}{"Total Mark",-15}");
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Id,-5}{assignment.Title,-15}{assignment.Description,-15}{assignment.SubmissionDate.Date,-15}{assignment.OralMark}{assignment.TotalMark}");
            }
        }
    }
}

