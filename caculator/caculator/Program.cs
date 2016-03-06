using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculator
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Addition Only Caculator");
            Console.WriteLine("Please Enter a Value");
            int myNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter a Second Value ");
            int myNum2 = int.Parse(Console.ReadLine());
            int myTotal = myNum1 + myNum2;

            Console.WriteLine("Then {0} + {1} = {2}", myNum1, myNum2, myTotal);
            Console.ReadLine();




        }
    }
}
