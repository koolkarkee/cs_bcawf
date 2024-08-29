using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    public static class MulticastDeleg
    {
        //for multicast purpose 
        public delegate int Chain(int n);


        //multicast implementation from  here
        private static int result = 5;
        private static int Add(int number)
        {
            result += number;
            return result;
        }

        private static int Multiply(int number)
        {
            result *= number;
            return result;
        }

        public static void ShowDemo()
        {
            /*delegates that hold more than one method are called as 
             multicast delegates. 
            Use the [+] and [-] operator to respectively add and subtract 
            more methods to delegate instance  
            */

            //creating delegate instance  
            Chain c1 = new Chain(Add);
            Chain c2 = new Chain(Multiply);

            Chain c = c1;
            c += c2;

            //finally calling multicast
            c(5);

            //c -= c2;
            //c(10);
            Console.WriteLine($"The value of result = {MulticastDeleg.result}");
        }

    }
}
