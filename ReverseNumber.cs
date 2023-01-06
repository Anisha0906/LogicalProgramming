using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public int Number;
        public int Reverse;
        public int Remainder;
        public void Reversenumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            Number = Convert.ToInt32(Console.ReadLine());
            Reverse = 0;
            while (Number > 0)
            {
                Remainder = Number % 10;
                Reverse = (Reverse * 10) + Remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is " + Reverse);
            Console.ReadLine();
        }
    }
}
