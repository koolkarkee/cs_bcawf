using CSharp_Fundamentals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    internal static class InterfaceDemo
    {
        public static void Show(IPhone iphone)
        {
            Console.WriteLine("--------------");
            try
            {
                iphone.SendMessage($"hello from {iphone.GetType().Name}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
