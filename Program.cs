//print hello world 
//Console.WriteLine("Hello, World Mr. Bibek Karki!");


//comments : single line comment 
/*This is a 
 multi line comemnt in C# */
using ConsoleApp1.Demos;
using ConsoleApp1.Model;

//Console.WriteLine("------------------------------------------");
//Console.WriteLine("SN\tName\t\tRoll Number");
//Console.WriteLine("------------------------------------------");

//Console.WriteLine("1\tSuraj Thapa\t\t22\n");
//Console.WriteLine("2\tNiraj Thapa\t\t23\n");
//Console.WriteLine("3\tDhiraj Thapa\t\t24\n");
//Console.WriteLine("------------------------------------------");

////basic data type 
//int x = 14; //integer : data type 
//double pie = 3.14;

//double CalculateArea(double radius)
//{
//    return pie * radius * radius; 
//}

//Console.WriteLine(x);
//double area = CalculateArea(x);
//Console.WriteLine("The area of circle is : " + area); 
//Console.WriteLine($"The area of circle is : {CalculateArea(x)}");

//string helloworld = "my name is anthony gonzalez!";
//Console.WriteLine(helloworld);

//instantiate the car object 
//Car maruti = new Car();
//maruti.Start();
//Console.WriteLine($"Your car has travelled {maruti.DistanceTravelled} Kms!");
//maruti.Price = 0.5;
//Console.WriteLine(maruti.Price.ToString());

////instantiate another car object 
//Car toyota = new Car("Red", 1235, 2.5, 1.4, DateTime.Now);
//Console.WriteLine(toyota.Price.ToString());

internal class Program
{
    public static void Main(string[] args)
    {
        ////instantiate another car object 
        //Car toyota = new Car("Red", 1235, 2.5, 1.4, DateTime.Now);
        ////Console.WriteLine(toyota.Price.ToString());
        //toyota.Start();
        //toyota.ShowDetails();

        //Car maruti = new Car();
        //maruti.Start();

        //StringDemo.DisplayMultiplicationTable(13);
        //StringDemo.DisplayMultiplicationTable(20);
        //StringDemo.DisplayCharArray();
        LoopDemo.DisplayLoop(1, 1, 10, 1);
        LoopDemo.DisplayLoop(1, 1, 10, 2);
        LoopDemo.DisplayLoop(1, 1, 1);

    }
}