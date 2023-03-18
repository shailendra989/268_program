using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class CheckInteger
    {
        public static void EqualOrNot()
        {
            Console.WriteLine("inpu0t integer1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your num1 is: " + num1);

            Console.WriteLine("input integer1");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your num2 is: " + num2);

            if (num1 == num2)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }

        }

    }
}
