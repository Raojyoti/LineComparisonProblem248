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
            Console.WriteLine("Length of Line1: {0}", lengthOfLine1);
            lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of Line2: {0}", lengthOfLine2);
            bool result = lengthOfLine1.Equals(lengthOfLine2);
            if (result == true)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
        //UC3- Compare two lines based on the end points
        public static void CompareTwoLines()
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
            Console.WriteLine("Length of Line1: {0}", lengthOfLine1);
            lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of Line2: {0}", lengthOfLine2);
            int result1 = Convert.ToInt32(lengthOfLine1.CompareTo(lengthOfLine2));
            if (result1 == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (result1 > 0)
            {
                Console.WriteLine("Line 1 is grater than line 2");
            }
            else
            {
                Console.WriteLine("line 2 is greater than line 1 ");
            }
        }
    }
}
