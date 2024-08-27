using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Interface
{
    internal interface IPhone
    {
        public void SendMessage(string message);
        public void ReceiveMessage();

        public void MakeCall();
        public void ReceiveCall();
    }
}
