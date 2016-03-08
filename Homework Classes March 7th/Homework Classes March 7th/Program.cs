using System;
using System.Collections.Generic;
using System.Dynamic;
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
            //names
            //greetings
            aHuman.DisplayName();
            bRobot.DisplayName();
            cPanda.DisplayName();

            aHuman.DisplayGreeting();
            bRobot.DisplayGreeting();
            cPanda.DisplayGreeting();

            //eat
            aHuman.Eat("Tacos");
            cPanda.Eat("Tacos");

            //Sleep
            aHuman.Asleep = true;
            cPanda.Asleep = true;

            //robot
            bRobot.Terminator = true;
            bRobot.StartUp();
            bRobot.ShutDown();

            Console.ReadLine();


        }
        
    }
}
