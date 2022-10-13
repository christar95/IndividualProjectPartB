using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.CourseView
{
    public class PrintCourse
    {
        public static void Print(Course course)
        {
            Console.WriteLine($"{"Id",-5}{"Title",-15}{"Stream",-15}{"Type",-15}{"Stream",-15}{"Start Date",-15}{"End Date",-15}");
            Console.WriteLine($"{course.Id,-5}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.Start_Date}{course.End_Date}");

        }

        public static void PrintAll(List<Course> courses)
        {
            Console.WriteLine($"{"Id",-5}{"Title",-15}{"Stream",-15}{"Type",-15}{"Stream",-15}{"Start Date",-15}{"End Date",-15}");
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,-5}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.Start_Date.Date}{course.End_Date.Date}");
            }
        }
    }
}
