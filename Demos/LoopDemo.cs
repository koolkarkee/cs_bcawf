using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demos
{
    internal static class LoopDemo
    {
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
    }
}
