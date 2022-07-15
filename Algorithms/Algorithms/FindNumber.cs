using System;
using System.Collections.Generic;

namespace DataStructure
{
    class FindNumber
    {
        public void Find()
        {
            Console.WriteLine("Enter a limit:");

            double N = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Math.Log(N, 2));
            Console.WriteLine("Enter a guess between 0 and" +" " + (N - 1));
            double firstValue = 0;
            double lastValue = N - 1;
            while (n > 0)
            {
                int mid = (int)(Math.Round(lastValue + firstValue) / 2);
                Console.WriteLine("Is this Greater than " + mid + "?");
                if (Console.ReadLine() == "y")
                {
                    firstValue = mid;

                }
                else
                {
                    lastValue = mid;
                }
                if ((firstValue - lastValue) == -1)
                {
                    Console.WriteLine("This is your Number " + (firstValue + 1));
                    return;
                }

                n -= 1;
            }
            Console.WriteLine("Taken more Than " + n + "chances");

        }
    }

}