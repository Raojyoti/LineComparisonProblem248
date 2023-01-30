using System;
using System.IO;
using static LineComparisonProblem.CartesianSystem;

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
                Console.WriteLine("1.CalculateLengthOfLine\n2.CheckEqualityOfTwoLines\n3.CompareTwoLines\n4.UsingOOPsConceptsComparetwolinesAndCheckEquality\n5.Exit\n");
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
                        CartesianSystem.CompareTwoLines();
                        break;
                    case 4:
                        Console.Clear();
                        CartesianSystem.CheckEqualityAndCompareTwoLines();
                        break;
                    case 5:
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
