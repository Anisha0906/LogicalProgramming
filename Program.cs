using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("Enter your choice 1.Fibonacci Series 2.Perfect Number ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    FibbonacciSeries FibboSeries = new FibbonacciSeries();
                    FibboSeries.CalculateFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber PerfectNum = new PerfectNumber();
                    PerfectNum.CheckPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            Console.ReadLine();
        }
    }
}
