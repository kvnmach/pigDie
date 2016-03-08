using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
    class Panda 

    {
        public string Name { get; set; }

        public bool Asleep = true;

        public void DisplayName()

        {
            Console.WriteLine("My name is Pandra");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Hello From Zoo");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum i ate {food}");
        }

        public void GoToSLeep();
        {
            Asleep = true;
        }

        public void WakeUp();
        {
            Asleep = false;
        }

        public void IsAsleep()
        {
            if (Asleep)
            {
                Console.WriteLine($"Panda is asleep");
            }
        }
    }

}
