using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    public static class GenericDeleg
    {
        //generic delegate declaration where T is our type 
        public delegate T Add<T>(T a, T b);

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static string Concat(string a, string b) {
            return a + b;
        }

        public static void ShowDemo()
        {
            Console.WriteLine("-------------------");

            //our delegate 
            Add<int> a = Sum;
            Console.WriteLine(a(5, 9));

            Add<string> b = Concat;
            Console.WriteLine(b("Bibek ", "Karki")); 
        }

    }
}
