using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class CheckOdd
    {
        public static void odd0rNot()
        {
            Console.WriteLine("inpu0t integer1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your num1 is: " + num1);

            if(num1%2 ==0 ) {
                Console.WriteLine("num1 is even");
            }
            else
            {
                Console.WriteLine("num2 is odd");
            }
        }
    }
}
