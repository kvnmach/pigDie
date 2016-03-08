using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
    public class Human
    {

        public string Name { get; set; }
        public string food { get; set; }

        public bool Asleep = false;

        public void DisplayName()
        {
            Console.WriteLine("Kevin");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine ("Hello from Human");
        }

        public void Eat(string food)
        {

            Console.WriteLine($"Yum i ate {food}");
        }

        public void GoToSleep()
        {
            Asleep = true;
        }

        public void WakeUp()
        {
            Asleep = false;
        }

        public void IsASleep()
        {
            if (Asleep)
            {
               Console.WriteLine($"{Name} is asleep");
            }
        }
        
    }
}
