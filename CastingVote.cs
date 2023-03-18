using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class CastingVote
    {
        public static void eligible()
        {
            Console.WriteLine("inpu0t integer1");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            if(age >= 18)
            {
                Console.WriteLine("Person is eligible for vote");
            }
            else
            {
                Console.WriteLine("person is not eligible for vote");
            }
            
        }
    }
}
