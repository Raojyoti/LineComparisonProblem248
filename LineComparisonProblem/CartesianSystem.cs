using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    public class CartesianSystem
    {
        //static variables
        public static double x1,x2,y1,y2;
        public static double lengthOfLine;
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
            Console.ReadLine();
        }
    }
}
