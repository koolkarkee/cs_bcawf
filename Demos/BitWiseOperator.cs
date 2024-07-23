using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demos
{
    internal static class BitWiseOperator
    {
        public static int i; 

        public static void TestBitWiseAnd(int a, int b)
        {
            var c = a & b; 
            Console.WriteLine($"{a} & {b} = {c}");
        }

        public static void TestBitWiseOr(int a, int b)
        {
            var c = a | b;
            Console.WriteLine($"{a} | {b} = {c}");
        }

        public static void TestBitWiseXor(int a, int b)
        {
            var c = a ^ b; 
            Console.WriteLine($"{a} ^ {b} = {c}");
        }

        public static void InvokeAll()
        {
            BitWiseOperator.TestBitWiseAnd(60, 13);
            BitWiseOperator.TestBitWiseOr(60, 13);
            BitWiseOperator.TestBitWiseXor(60, 13);

            //7 = 0111
            //9 = 1001
            //7 & 8 = 0001
            BitWiseOperator.TestBitWiseAnd(7, 9);
            BitWiseOperator.TestBitWiseOr(7, 8);
            BitWiseOperator.TestBitWiseXor(7, 8);
        }
    }
}
