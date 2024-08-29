using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    //C# delegate allows you to treat a method as a value
    public static class SimpleDelegate
    {
        //declaring delegates 
        public delegate int StrToInt(string s);
        public delegate double PerformCalculation(double x, double y);

        //a method to convert a number in string format to an integer 
        private static int ConvertToNumber(string s)
        {
            if (int.TryParse(s, out int result))
                return result;

            return 0;
        }

        //a method to calculate the square root of sum of squares of two given numbers 
        private static double CalculateSquareRoot(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }

        //a method to calculate the area of a rectangle 
        private static double CalculateArea(double length, double breadth)
        {
            return length * breadth;
        }

        public static void ShowDemo()
        {
            //assigning a method to delegate, note that signature should be compatible 
            StrToInt x = ConvertToNumber;

            Console.WriteLine(x("200")); //convert "200" to int 
            Console.WriteLine(x.Invoke("300")); //convert "300" to int 
            Console.WriteLine(x("xyz")); //convert "xyz" to int 

            Console.WriteLine("-----------------------");

            //PerformCalculation p = ConvertToNumber; //shows error 

            PerformCalculation p = CalculateSquareRoot;
            Console.WriteLine(p(3, 4));
            Console.WriteLine(p.Invoke(12, 16));

            Console.WriteLine("-----------------------");
            p = CalculateArea; //changing the value of p now 
            Console.WriteLine(p(3, 4));
            Console.WriteLine(p.Invoke(12, 16));

            Console.WriteLine("-----------------------");
            p = CalculateSquareRoot;
            var a = p(3, 4);
            p = CalculateArea;
            var b = p(3, 4); 
            p = CalculateSquareRoot;
            Console.WriteLine(p(a, b));

            Console.WriteLine("-----------------------");
        }

    }
}
