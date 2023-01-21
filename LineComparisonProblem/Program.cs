using System;
using System.IO;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            while (true)
            {
                Console.WriteLine("Select given options");
                Console.WriteLine("1.CalculateLengthOfLine\n2.CheckEqualityOfTwoLines\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        CartesianSystem.CalculateLengthOfLine();
                        break;
                    case 2:
                        Console.Clear();
                        CartesianSystem.CheckEqualityOfTwoLines();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only given options");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
