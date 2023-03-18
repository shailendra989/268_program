using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class LargestThree
    {
        public static void ThreeNumbers() {

            Console.WriteLine("inpu0t integer1");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your p1 is: " + p1);

            Console.WriteLine("inpu0t integer1");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your p2 is: " + p2);

            Console.WriteLine("inpu0t integer1");
            int p3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your p3 is: " + p3);

            if (p1 > p2 && p1 > p3)
            {
                Console.WriteLine("p1 is bigger");
            }
            else if (p2 > p1 && p2 > p3) {
                
                Console.WriteLine("p2 is bigger");
            }
            else
            {
                Console.WriteLine("p3 is bigger");
            }
            }
        }

    }
