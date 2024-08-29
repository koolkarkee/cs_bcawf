using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    public static class Lambdas
    {
        //declaring delegates for anonymous methods 
        public delegate void Display(string s);
        public delegate void Add(int a, int b);

        //anonymous functions in action 
        private static void DemoAnonymousMethod()
        {
            //one anonymous method  
            Display d = delegate (string s)
            {
                Console.WriteLine($"The length of the string '{s}' is {s.Length}");
            };
            d("Bibek Karki");

            //another anonymous method 
            Add a = delegate (int a, int b)
            {
                Console.WriteLine($"The sum of {a} and {b} is {a + b}");
            };
            a(5, 7);

            Console.WriteLine("------------------");
        }

        //lambda expressions 
        static int SimpleLambda() => 5;

        /*
            int SimpleLambda(){
                return 5; 
            }
         */

        static int SquareLambda(int a) => a * a;
        /*
            int SquareLambda(int a){ return a*a; }
         */
         
        public delegate void CalculateSquare(int n); 

        private static void DemoLambdaExpression()
        {
            int a = SimpleLambda(); //call the lambda function to get the result
            Console.WriteLine(a);

            int b = SquareLambda(a);
            Console.WriteLine(b);

            ////lambda with multiple statements : anonymous lambda
            var sum = (int a, int b) => //one of my favourites 
            {
                var result = a + b;
                Console.WriteLine($"{a} + {b} = {result}");
            };
            /*
            void Add(int a, int b){
                var result = a + b;
                Console.WriteLine($"{a} + {b} = {result}");
            }; 
             */
            sum(a, b);

            ////lambda via delegates :  multiple statments 
            CalculateSquare calc = x =>
            {
                Console.WriteLine($"Input = {x}");
                Console.WriteLine($"Output = {x * x}");
            };
            calc(5); 
            Console.WriteLine("--------------------");
        }

        public static void ShowDemo()
        {
            DemoAnonymousMethod();
            DemoLambdaExpression();
        }
    }
}
