using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
     public class Robot
     {
        
         public string StartUp()
         {
             return "Started";
         }

         public string ShutDown()
         {
             return "Shutdown";
         }

          public string DisplayName()
         {
             return"Mr.Roboto";
         }

         public string DisplayGreeting()
         {
             return "I'm a Robot";
         }

         bool isTerminator = true;

         bool isASleep = false;

     }
}
