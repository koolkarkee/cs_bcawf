using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    internal static class ConversionDemo
    {
        public static void DisplayConversion(int x)
        { 
            var y = (float)x;
            Console.WriteLine(y);

            var z = (double)y;
            Console.WriteLine(z);

            var a = 20.6;
            var b = (int)a;
            Console.WriteLine(b);

            //implicit conversion 
            var c = 20;
            Console.WriteLine(c);

            var d = 20.4;
            Console.WriteLine(d);

            char e = 'a';
            string f = e.ToString(); 
            Console.WriteLine(f);
        }

        //null coalescing operator 
        public static void ShowCoalese(int? x)
        {
            string a = null;
            
            string b = (a ?? "nothing");
            Console.WriteLine(b);

            string c = "NULL";
            string d = (c ?? "ok");
            Console.WriteLine(d); 
        }

        public static void ShowAssociativiy()
        {
            var a = 2;

            int b, c, d;
            //b = 2;
            //c = 2;
            //d = 2;

            b = c = d = a;
            Console.WriteLine($"{a} {b} {c} {d}");
        }

    }
}
