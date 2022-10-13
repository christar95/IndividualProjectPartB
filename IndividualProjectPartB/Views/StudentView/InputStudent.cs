using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.StudentView
{
    public class InputStudent
    {
        public Student GetNewStudentData()
        {
            Console.WriteLine("Student's Name");
            string name = Console.ReadLine();
            Console.WriteLine("Student's Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Date of Birth");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Tuition Fees");
            int fees = int.Parse(Console.ReadLine());
            return new Student() { FirstName = name, LastName = surname, DateOfBirth = birthdate, TuitionFees = fees };
        }
    }
}
