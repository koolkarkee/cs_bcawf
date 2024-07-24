using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demos
{
    internal static class StringDemo
    {
        //display the multiplication table: (1 to 10)
        public static void DisplayMultiplicationTable(int n) {
            Console.WriteLine($"Multiplication table of {n}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{n} * \t{1} \t= \t{n * 1}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{2} \t= \t{n * 2}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{3} \t= \t{n * 3}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{4} \t= \t{n * 4}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{5} \t= \t{n * 5}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{6} \t= \t{n * 6}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{7} \t= \t{n * 7}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{8} \t= \t{n * 8}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{9} \t= \t{n * 9}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"{n} * \t{10} \t= \t{n * 10}");
            Console.WriteLine("-----------------------------\n");
        }


        public static void DisplayMultiplicationTable(int n, int start, int end, int steps) 
        { 
            Console.WriteLine($"Multiplication table of {n}");
            Console.WriteLine("-----------------------------");

            for (int i = start; i <= end ; i = i + steps)
            {
                Console.WriteLine($"{n} * \t{i} \t= \t{n * i}");
            } 

            Console.WriteLine("-----------------------------");
        }

        public static void DisplayCharArray()
        {
            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            Console.Write(a.ToString());
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);

            int x = 50;
            Console.Write("  " + x + "©");
        }
    
    }
}
