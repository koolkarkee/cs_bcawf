using CSharp_Fundamentals.Inheritance;
using CSharp_Fundamentals.Interface;
using CSharp_Fundamentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    internal static class InheritanceDemo
    { 
        private static void DemoOfficer()
        {
            //instantiation of base class 
            Officer officer = new Officer();
            officer.Name = "John".ToUpper();
            officer.Age = 25;
            Console.WriteLine(officer.Department);
            //Console.WriteLine(officer.Salary); //it is a private member
            officer.Arrest();
            Console.WriteLine($"Age of officer is {officer.Age}");
            //Console.WriteLine($"Level of officer is {officer.Level}"); //inaccessible
            officer.Fine(100);
        }

        private static void DemoTraffic()
        {
            //instatiation of derived class 
            Traffic traffic = new Traffic();
            traffic.Name = "Parker".ToUpper();
            traffic.Age = 29;
            traffic.Arrest();
            Console.WriteLine($"Age of traffic is {traffic.Age}");

            /*
             The following line of code is inaccessible:

             Console.WriteLine($"Level of traffic is {traffic.Level}");
             Here, the class member "Level" is inaccessible from the outside

             However, "Level" can be accessed from WITHIN our derived class Traffic by 
             using "base" keyword
             */

            //accessing "Level" 
            traffic.ShowLevel();
            Console.WriteLine(traffic.Department);
            traffic.Fine(100);
            //traffic.Help(); //access restricted 
            traffic.Helpme(); //use this method to indirectly access the Help() method
        }

        private static void DemoAbstract()
        {
            //Shape shape = new Shape();
            Circle circle = new Circle();
            circle.Radius = 7;
            circle.ShowArea();
        }

        private static void DemoSealed()
        {
            FileHandler fileHandler = new FileHandler();
        }

        private static void DemoEnums()
        {
            //suppose that we have inserted in db
            Console.WriteLine($"Key = {CRUDEnums.CREATED} and Value = {(int)CRUDEnums.CREATED}");
        }

        public static void Show()
        {
            DemoOfficer();

            Console.WriteLine("--------------------");
            DemoTraffic();
            //
            Console.WriteLine("--------------------");

            DemoAbstract();
            Console.WriteLine("--------------------");

            DemoSealed();
            Console.WriteLine("--------------------");

            DemoEnums(); 
        } 

    }
}
