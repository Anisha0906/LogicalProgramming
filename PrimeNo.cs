using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PrimeNo
    {
        public void CheckPrimeNumber()
        {
            int num, i, count = 0;
            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.Write("It is a prime number");
            else
                Console.Write("It is not a prime number");
        }
    }
}
