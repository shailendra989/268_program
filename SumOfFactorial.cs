using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class SumOfFactorial
    {
        public static void Factorial()
        {
           
                Console.WriteLine("input a value - ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n);
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                sum = 5 * i;
                }
                Console.WriteLine(sum);
                
            
        }
    }
}
   

