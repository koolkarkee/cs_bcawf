using CSharp_Fundamentals.Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{
    //using delegates with events 
    /*
     * A publisher is an object that contains the definition of the 
     * event and the delegate. The event-delegate association is also 
     * defined in this object. A publisher class object invokes the 
     * event and it is notified to other objects.
     * 
     * A subscriber is an object that accepts the event and provides 
     * an event handler. The delegate in the publisher class invokes 
     * the method (event handler) of the subscriber class.
     */

    public class SimpleEvent
    {
        //declare delegate 
        public delegate string MyEventHandler(string s);
        public delegate void PrintHandler(int value);

        //declare event 
        event MyEventHandler handler;
        event PrintHandler printHandler;

        //constructor  
        public SimpleEvent()
        {
            //instance
            this.handler += new MyEventHandler(this.Speak);
            this.printHandler += new PrintHandler(this.PrintNumber);
        }

        void AddPrintCurrencyHandler()
        {
            this.printHandler += new PrintHandler(this.PrintCurrency);
        }

        void RemovePrintCurrencyHandler()
        {
            this.printHandler -= new PrintHandler(this.PrintCurrency);
        }

        void RemovePrintNumberHandler()
        {
            this.printHandler -= new PrintHandler(this.PrintNumber);
        }

        //method
        private string Speak(string name)
        {
            return $"Hello {name}";
        }

        private void PrintNumber(int n)
        {
            Console.WriteLine("Number: {0,-12:N0}", n);
        }

        private void PrintCurrency(int n)
        {
            Console.WriteLine("Money: {0:C}", n);
        }

        public static void ShowFirst()
        {
            SimpleEvent simpleEvent = new SimpleEvent();
            string result = simpleEvent.handler("Bibek Karki");
            Console.WriteLine(result);
        }

        public static  void ShowSecond()
        {
            SimpleEvent simple = new SimpleEvent();
            simple.printHandler(20000000);

            Console.WriteLine();

            simple.AddPrintCurrencyHandler();
            simple.printHandler(3000);

            Console.WriteLine();

            simple.RemovePrintCurrencyHandler();
            simple.printHandler(6000);
        }

    }
}
