using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    public static class LINQDemo
    {

        public static List<int> FindEvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int i in list) {
                if (i % 2 == 0) { 
                    result.Add(i);
                }
            }

            return result;
        }

        public static void Show()
        {
            //LINQ 
            List<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            //var evenNumbers = FindEvenNumbers(list);
            var evenNumbers = list.FindAll(x => x % 2 == 0 && x < 25);
            foreach (int i in evenNumbers) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            var oddNumbers = from s in list where s % 2 != 0 && s < 25 select s;
            foreach (int i in oddNumbers) {
                Console.Write($"{i} ");
            }
        }
    }
}
