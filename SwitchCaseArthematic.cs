﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class SwitchCaseArthematic
    {
        public static void  Arthematic() {

            Console.Write("Enter No1: ");
            int a =0;
            try
            {
                 a = Convert.ToInt16(Console.ReadLine());

            }
            catch {
                Console.WriteLine("Please enter integer");
            }
            Console.Write("Enter No2: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Divsion");
            Console.WriteLine("4.Multiplication");
            Console.WriteLine("5.Increment");
            Console.WriteLine("6.Decrement");
            
            int c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Division Of Two Numbers : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                    break;
                case 5:
                    Console.WriteLine("Increment Numbers : " + (++a) + " " + (++b));
                    break;
                case 6:
                    Console.WriteLine("Decrement Numbers : " + (--a) + " " + (--b));
                    break;
                default:
                    Console.WriteLine("Choose Only 1 To 6 ");
                    break;
            }
            Console.ReadLine();


        }
    }
}
