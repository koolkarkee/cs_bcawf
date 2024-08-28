using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Fundamentals.Interface;

namespace CSharp_Fundamentals.Model
{
    public class Motorola : IPhone
    {
        public Motorola() { }

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
