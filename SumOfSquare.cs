using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class SumOfSquare
    {
        public static void SumN()
        {
            Console.WriteLine("input a value - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (i * i);
            }
            Console.WriteLine("sum of first N natural numbers ="+sum);
        }
    }
}
