using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack___
{
    class Program
    {
        static void Main(string[] args)
        {
            TitlePage();

            //
        }

        private static void TitlePage()
        {
            Console.WriteLine("Welcome to BlackJack!");
            Console.WriteLine("INSTRUCTIONS: Dealer STAYS on  16, Hit 21 You WIN!, Over 21 you LOSE!");
            Console.WriteLine("Press any key to continue");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
