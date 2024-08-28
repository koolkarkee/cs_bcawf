using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Inheritance
{
    public class Traffic : Officer
    {
        //default constructor 
        public Traffic()  
        {
            Console.WriteLine("Traffic constructor called from derived class.. ");
        }

        //access protected member of the parent class using base keyword
        public void ShowLevel()
        {
            Console.WriteLine($"Level of the officer is {base.Level}");
        }

        //overriding Fine() method 
        public override void Fine(double amount)
        {
            Console.WriteLine($"You have been fined NRs. {amount * 134}");
        }

        //overriding Help() method
        protected override void Help()
        {
            //simply access the Help() method of the base class with "base" keyword
            base.Help();

            //or overload it as below: 
            Console.WriteLine("Help needed (for traffic)!");
        }

        //invoke this to call Help() method 
        public void Helpme()
        {
            Help();
        }

    }
}
