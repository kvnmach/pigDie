using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigDie
{
    class Program
    {
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            
                //create a title player screen
                Console.WriteLine("PigDICE!!!!");
                Console.WriteLine("Press any button to Continue!");
                DateTime present = DateTime.Now;
                Console.WriteLine(present);

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("['_']");
                Console.WriteLine("rolling dice....");
                Console.ReadLine();

                //create characters
                //generate random numbers for dice









                while (gameTotal < 100)
                {


                    int dice = rnd.Next(1, 7);
                    Console.WriteLine(dice);

                    bool keepgoing = true;
                    while (keepgoing)

                        if (dice == 1)
                        {
                            Console.WriteLine("You rolled 1, Lost Turn");
                            break;

                        }

                        else
                        {
                            Console.WriteLine($"You rolled {dice}. Your Total Score is Now");
                            Console.WriteLine("8)");
                            Console.WriteLine("press any key to continue...");

                        }

                }
            }





            // turnTotal += dice;
            //ifdice == 1 


            //while (gt < 100)

            //Roll dice
            //if 1 turn score<0, go to next turn
            // else not 1 add dice roll to turn total
            // ask if bank or roll
            //if b add tt to gt
            //if r loop to while.


            //(player turn loop
            //Sum and hold scores
            //add value to 2 through 6


            //let it loop the value of die


            //create a limit for score

            //create true false values

            //interger for addition
            //end game with >=100



        }
    }
}
    }
}
