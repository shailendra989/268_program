using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class whileloopSum
    {
        public static void sum()
        {
            int sum = 0; 
            int i = 1; 

            while (i <= 5) 
            {
                sum += i;
                i++; 
            }

            Console.WriteLine("The sum of the first 5 natural numbers is: " + sum);
        }
    }
}
