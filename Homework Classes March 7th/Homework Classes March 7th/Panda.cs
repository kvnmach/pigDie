using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
     class Panda
    
    {
        public bool IsASleep = true;
        public string DisplayName()
        {
            return"Pandra";
        }

        public string DisplayGreeting()
        {
            return"Hello from Zoo";
        }

         public void Eat(string food)
         {
             Console.WriteLine($"Yum i ate {food}");
         }

    }
}
