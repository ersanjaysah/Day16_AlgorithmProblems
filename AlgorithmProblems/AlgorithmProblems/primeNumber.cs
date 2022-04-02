using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class primeNumber
    {
        public static void CheckPrime()
        {
            for (int number = 0; number < 1000; number++)
            {
                int count = 0;

                for (int j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
            }
            
           
        }
    }
}
