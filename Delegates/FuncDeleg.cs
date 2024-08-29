using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    public static class FuncDeleg
    {
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void ShowDemo()
        {
            Console.WriteLine("---------------");
            Func<int, int, int> f1 = Sum; 
            int a = f1(1, 2);

            //updatte Add
            Func<int, int, int, int> f2 = Sum; 
            int b = f2(a, 3, 5); 

            Console.WriteLine($"a = {a} and b = {b}");

            Console.WriteLine("---------------");
            //action delegate sample using lambda expression 
            Action<int, int> Calc = (a, b) =>
            {
                Console.WriteLine($"Addition result: {a + b}");
                Console.WriteLine($"Subtraction result: {a - b}");
                Console.WriteLine($"Multiplication result: {a * b}");
                Console.WriteLine($"Division result: {a / b}");
            };

            Calc(10, 2);
            Console.WriteLine("---------------");
        }

        
    }
}
