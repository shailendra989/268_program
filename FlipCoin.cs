using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class FlipCoin
    {
        public static void flip()
        {
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            while (heads <= 20 || tails <= 20)
            {
                int result = rnd.Next(2);
                if (result == 0)
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("Tails");
                }
            }

            if (heads == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }

    }


     
}
