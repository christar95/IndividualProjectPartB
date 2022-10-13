using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Views.TrainerView
{
    public class PrintTrainer
    {
        public static void Print(Trainer trainer)
        {
            Console.WriteLine($"{"Id",-5}{"First Name",-15}{"Last Name",-15}{"Subject",-15}");
            Console.WriteLine($"{trainer.Id,-5}{trainer.FirstName,-15}{trainer.LastName,-15}{trainer.Subject,-15}");

        }

        public static void PrintAll(List<Trainer> trainers)
        {
            Console.WriteLine($"{"Id",-5}{"First Name",-15}{"Last Name",-15}{"Subject",-15}");
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Id,-5}{trainer.FirstName,-15}{trainer.LastName,-15}{trainer.Subject,-15}");
            }
        }
    }
}
