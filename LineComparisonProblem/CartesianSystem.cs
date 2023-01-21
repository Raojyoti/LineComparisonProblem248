using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    public class CartesianSystem
    {
        //static variables
        public static double x1,x2,x3,x4,y1,y2,y3,y4;
        public static double lengthOfLine, lengthOfLine1, lengthOfLine2;
        //UC1- Calculate length of line
        public static void CalculateLengthOfLine()
        {
            Console.WriteLine("Please Enter the values for x1 and x2: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the values for y1 and y2: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line: {0}", lengthOfLine);
        }
        //UC2- Check Equality Of Two Lines
        public static void CheckEqualityOfTwoLines()
        {
            Console.WriteLine("Please Enter the values for x1 and x2: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the values for y1 and y2: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the values for x3 and x4: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the values for y3 and y4: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            lengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line: {0}", lengthOfLine1);
            lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of Line: {0}", lengthOfLine2);
            bool checkEquality=lengthOfLine1.Equals(lengthOfLine2);
            Console.WriteLine("Equality Of Two Lines: {0}",checkEquality);
        }
    }
}
