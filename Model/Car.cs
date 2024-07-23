using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Helper;

namespace ConsoleApp1.Model
{
    internal class Car
    {
        //attributes : color, model, height, price, manufactured_date
        public string Color { get; set; }
        public int Model { get; set; }
        public double Height { get; set; }
        public double Price { get; set; }
        public DateTime ManufacturedDate { get; set; }

        public double DistanceTravelled { get; set; }

        //static constructor 
        static Car()
        {
            Console.WriteLine("Launching the program .... ");
        }

        //constructor (two)
        //default constructor 
        public Car()
        {
            DistanceTravelled = 0;
        }

        //overloading constructor 
        public Car(string Color, int Model, double Height, double Price, DateTime ManufacturedDate)
        {
            DistanceTravelled = 0;

            //set the attributes 
            this.Color = Color;
            this.Model = Model;
            this.Height = Height;
            this.Price = Price;
            this.ManufacturedDate = ManufacturedDate;
        }

        //implement methods 
        //methods : start, drive, stop, accelerate, maneuver 

        public void Start()
        {
            MediaHelper.PlayAudio(MediaHelper.CAR_START);
            Console.WriteLine("The car has started!");
        }

        public void ShowDetails()
        {
            Console.WriteLine("-----------------------");

            Console.WriteLine("Details\n");
            Console.WriteLine($"Price\t\t${Price}m");
            Console.WriteLine($"Color\t\t{Color}");
            Console.WriteLine($"Model\t\t22-AV{Model}");
            Console.WriteLine($"Height\t\t{Height}m");
            Console.WriteLine($"Mfd Date\t{ManufacturedDate}");
            Console.WriteLine($"Distance\t{DistanceTravelled}Km");

            Console.WriteLine("-----------------------");
        }

        public void Stop()
        {
            Console.WriteLine("The destination has arrived!");
        }

        //destructor (finalizer) 
        //destructors are invoked automatically 
        ~Car()
        {
            Console.WriteLine("The object has been destroyed ... ");
        }

    }
}
