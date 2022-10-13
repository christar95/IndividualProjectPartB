using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.TrainerView
{
    public class InputTrainer
    {
        public Trainer GetNewTrainerData()
        {
            Console.WriteLine("Trainer's Name");
            string name = Console.ReadLine();
            Console.WriteLine("Trainer's Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Trainer's subject");
            string subject = Console.ReadLine();
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Tuition Fees");
            int fees = int.Parse(Console.ReadLine());
            return new Trainer() { FirstName = name, LastName = surname, Subject=subject };
        }
    }
}
