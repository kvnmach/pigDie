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
            int i = 21;
            while (true)
            {
               

                }
                  
                    {
                    
                 
                    
                    
            }

            


            //SUIT . RANK NEEDS TO GO TOGETHER
            //shuffle deck
            //BUILD A CLASS
            //draw cards to players 2 each
            //BUILD IF ELSE STATEMENT TO SEE IF PLAYERS WANT TO HIT OR HOLD
            //hits until desired amount
            //HAVE TO RECOGNIZE A SCORE
            //+=
            //IF ELSE STATEMENT += EQUALS == THEN 
            //BUILD IF ELSE STATEMENT IF IT GOES OVER 21 FOR BOTH PLAYERS (BUSTS); IF LESS THAN 16 DRAW FOR DEALER; IF => 16  THEN HOLD FOR DEALER
            //for each statement to generate READLINE 
            //draw cards to dealer 2 each 1 hidden
            //hits until it goes to 16
            //LOOP
            //dealer stays on 16 
            //21 wins
            // >21 busts
            //52 cards maxed
            //KQJ = 10
            //A = 11
            
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
