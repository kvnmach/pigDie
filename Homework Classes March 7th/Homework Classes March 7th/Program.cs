using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Classes_March_7th
{//
    class Program
    {
        static void Main(string[] args)
        {
            Human aHuman = new Human();
            Robot bRobot = new Robot();
            Panda cPanda = new Panda();

            aHuman.DisplayName();
            bRobot.DisplayName();
            cPanda.DisplayName();

            bRobot.StartUp();
            bRobot.ShutDown();

            
            Console.ReadLine();


        }
        
    }
}
