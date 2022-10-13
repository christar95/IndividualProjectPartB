using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.StudentView
{
    public class PrintStudent
    {
        public static void Print(Student student)
        {
            Console.WriteLine($"{"Id",-5}{"First Name",-15}{"Last Name",-15}{"Birth Date",-15}{"Tuition Fees",-15}");
            Console.WriteLine($"{student.Id,-5}{student.FirstName,-15}{student.LastName,-15}{student.DateOfBirth,-15}{student.TuitionFees,-15}");

        }

        public static void PrintAll(List<Student> students)
        {
            Console.WriteLine($"{"Id",-5}{"First Name",-15}{"Last Name",-15}{"Birth Date",-15}{"Tuition Fees",-15}");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,-5}{student.FirstName,-15}{student.LastName,-15}{student.DateOfBirth.Date,-15}{student.TuitionFees,-15}");
            }
        }
    }
}
