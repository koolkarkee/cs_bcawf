using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Delegates
{ 
    public class Button
    {
        //step 1: delegate
        public delegate void ButtonClickedEventHandler();

        //step 2: event 
        public event ButtonClickedEventHandler Clicked; 

        public void PressButton()
        {
            Console.WriteLine("Button Clicked!");

            //step 3 : raising the event 
            Clicked?.Invoke();
        } 
    }

    public class User
    {
        //step 4: event handling method  
        public void StartCar()
        { 
            //start our car 
            new Car().Start();

            Console.ReadKey();
        }
    }

    public static class ButtonEvent
    { 
        public static void ShowDemo()
        {
            Button button = new Button();
            User user = new User();

            //step 5: subscribe to the event 
            button.Clicked += user.StartCar;

            //trigger the event 
            button.PressButton();
        }
    }
}
