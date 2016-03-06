using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace making_decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kevins Lawn Mowing Service");
            Console.WriteLine("Please Enter the Length of Your Yard");
            int yardLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Width Size");
            int yardWidth = int.Parse(Console.ReadLine());
            int totalSQFT = yardLength*yardWidth;
            double weeklyPrice = 25.00*20;


            
            if (totalSQFT <= 400)
            {
                double myNum1 = 25.00 * 20;
                Console.WriteLine(
                    "Because Your Yard is {0} we will charge you 25.00 weekly", totalSQFT);
                Console.WriteLine("Your Season Price is {0}.", myNum1);
            }
            else if (totalSQFT >= 400 && totalSQFT < 600 )
            {
                double myNum2 = 35.00 * 20;
                Console.WriteLine("Because Your Yard is {0} we will charge you 35.00.",
                    totalSQFT );
                Console.WriteLine("Your Season Price is {0}.", myNum2);
            }

            else if(totalSQFT >=600) 
            {
                double myNum3 = 50.00 * 20;
                Console.WriteLine("Because your Yard is {0} we will chard you 50.00.", totalSQFT);
                Console.WriteLine("Your Season Price is {0}.", myNum3);
            }
            Console.WriteLine("Thank You for Choosing Kevins Lawn Mowing Service");

            Console.ReadLine();

        }
    }
}
