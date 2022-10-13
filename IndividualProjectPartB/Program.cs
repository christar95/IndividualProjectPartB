using IndividualProjectPartB.Entities;
using IndividualProjectPartB.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndividualProjectPartB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                App.Run();
                Console.WriteLine("Do you want to run again?");
                Console.WriteLine("Type Y or N");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer=="Y");
            
        }
    }
}
