using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingDecisions2
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("How Many Number of Students");
            int numStudent = int.Parse(Console.ReadLine());
            double[] myStudent1 = new double[numStudent];

            for (int i = 0; i < myStudent1.Length; i ++) 
            {
                Console.WriteLine("Enter Students Number #{0}", i + 1);
                myStudent1[i] = double.Parse(Console.ReadLine());

            }
            double average = 0;
            for (int i = 0; i < myStudent1.Length ; i ++)
            {
                average += myStudent1[i];
                Console.WriteLine("Your Student # {0} grade is {1}.", i + 1 ,myStudent1 [i] );

            }
            Console.WriteLine("Class Average is {0}.", average/myStudent1.Length);
            Console.ReadLine();





        }
    }
}
