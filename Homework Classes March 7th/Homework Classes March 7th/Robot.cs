using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{
    public class Robot
    {
        public bool Terminator = false;
        public bool IsShutdown = true;

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
            return ("Mr.Roboto");
        }

        public string DisplayGreeting()
        {
            return "I'm a Robot";
        }


        public void IsTerminator()
        {
            if (Terminator)
            {
                Console.WriteLine("I'm a terminator");
            }
            else
            {
                Console.WriteLine("I'm not a Terminator");
            }
        }

        public void isAsleep()
        {
            if (IsShutdown)
            {
                Console.WriteLine("ShutDown");
            }
        }
     








    }
}

