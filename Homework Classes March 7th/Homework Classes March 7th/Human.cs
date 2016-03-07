using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
    public class Human
    {
        public bool IsASleep = true;
        
            
        

        public string DisplayName()
        {
            return "Kevin";
        }

        public string DisplayGreeting()
        {
            return "Hello from Human";
        }

        public void Eat(string food)
        {

            Console.WriteLine($"Yum i ate {food}");
        }

        public void GoToSleep()
        {
            Console.WriteLine("Go To Sleep");
        }

        public void WakeUp()
        {
            Console.WriteLine("Wake Up");
        }

    }
}
