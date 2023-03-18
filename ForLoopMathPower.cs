using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class ForLoopMathPower
    {
        public static void power()
        {
            Console.WriteLine("input a value - ");
            int n =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);

            for(int i  = 1;i <= n;i++)
            {
             //   Console.WriteLine(i);

             double  power_two = Math.Pow(2,i);
                Console.WriteLine(power_two);
            }
        }
    }
}
