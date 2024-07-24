using ConsoleApp1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demos
{
    internal static class LoopDemo
    {
        public static void DispalySimpleLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World"); 
            }
        }

        public static void DisplayLoop(int looptype, int start, int end, int steps)
        {
            int i;
            if (looptype == 1) // demo for loop
            {
                for (i = start; i < end; i = i + steps)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }

        public static void DisplayLoop(int looptype, int start, int steps)
        {
            int i;
            if (looptype == 1) // demo for loop
            {
                for (i = start; ; i = i + steps)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }

        public static void DisplaySwitchCase(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public static void DisplayForeach()
        {
            Console.WriteLine("----------------");

            ArrayList bag = new ArrayList();
            bag.Add("pen");
            bag.Add("rupees"); 
            bag.Add(10);
            bag.Add(20.5);
            bag.Add(true);

           
            foreach (var item in bag)
            {
                Console.WriteLine(item);
                //Console.WriteLine("Give me 5 Rs!");
            }

        }

    }
}
