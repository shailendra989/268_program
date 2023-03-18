using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class Admission
    {
        public static void eligible()
        {
            int mathMarks, phyMarks, chemMarks;
            Console.Write("Input the marks obtained in Physics :");
            phyMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            chemMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            mathMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = mathMarks + phyMarks + chemMarks;

            if ((mathMarks >= 65 && phyMarks >= 55 && chemMarks >= 50) || totalMarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks >= 65 && totalMarks >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
