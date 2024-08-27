using CSharp_Fundamentals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Inheritance
{
    public class Motorola : IPhone
    {
        void IPhone.MakeCall()
        {
            Console.WriteLine("Making call");
        }

        void IPhone.ReceiveCall()
        {
            Console.WriteLine("Receiving call");
        }

        void IPhone.ReceiveMessage()
        {
            Console.WriteLine("Message received");
        }

        void IPhone.SendMessage(string message)
        {
            Console.WriteLine($"Message sent: {message}");
        }
    }
}
