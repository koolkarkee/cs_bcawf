using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    internal static class CollectionDemo
    {
        //Collections => List, ArrayList, Stack, Queue, Dictionary
        private static void DemoList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach (var item in list) { 
                Console.WriteLine(item);
            }

            list.Remove(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void DemoArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(3.5);
            arrayList.Add("Ram");
            arrayList.Add(66);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }

            arrayList.Remove(1);
            Console.WriteLine();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            } 
        }

        public static void Show()
        {
            DemoList();
            Console.WriteLine();
            DemoArrayList();
        }

    }
}
