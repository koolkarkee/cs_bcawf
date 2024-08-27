using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Inheritance
{
    public class Officer
    {
        //private members  
        private double Salary;

        //getter setters
        //public members 
        public string Department = "Department of Public Service";

        public string? Name { get; set; }
        public int Age { get; set; }

        //protected member
        protected int Level { get; set; } 

        //constructor 
        public Officer() {
            Console.WriteLine("Officer Constructor called from base class... ");
            this.Salary = 5000;
            this.Level = 1;
        }

        //overloaded constructor 
        public Officer(string name, int age, int Level) {
            this.Name = name;
            this.Age = age;
            this.Level = Level;
        }

        //public method is accesible to the derived class 
        public void Arrest()
        {
            Console.WriteLine($"{this.Name} have been arrested!");
        }

        //allowing this method to be overridden in the derived class from the base class
        public virtual void Fine(double amount)
        {
            Console.WriteLine($"You have been fined ${amount}");
        }


        //another public virtual method  
        protected virtual void Help()
        {
            Console.WriteLine($"Help needed (for {this.Name})!");
        }
    }
}
