using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class SwitchWeekDay
    {

        public static void weekday()
        {
            Console.WriteLine("enter mumber");
            int weak = Convert.ToInt32(Console.ReadLine());

            switch (weak)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    {
                        Console.WriteLine("invalid data");
                        break;

                    }

            }


        }
    }
}

    

