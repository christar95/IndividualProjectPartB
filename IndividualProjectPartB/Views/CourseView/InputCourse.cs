using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = IndividualProjectPartB.Enums.Type;

namespace IndividualProjectPartB.Views.CourseView
{
    public class InputCourse
    {
        public Course GetNewCourseData()
        {
            Console.WriteLine("Title");
            string title = Console.ReadLine();
            Console.WriteLine("Stream");
            string stream = Console.ReadLine();
            Console.WriteLine("Type");
            string type = Console.ReadLine();
            Type courseType = (Type)Enum.Parse(typeof(Type),type, true);
            Console.WriteLine("Start Date");
            DateTime sdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("End Date");
            DateTime edate = Convert.ToDateTime(Console.ReadLine());
            return new Course() { Title = title, Stream = stream, Type = courseType, Start_Date = sdate, End_Date = edate };
        } 
    }
}
