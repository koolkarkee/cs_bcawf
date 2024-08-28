using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Model
{
    public abstract class Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public double Radius { get; set; }

        public Shape() {
            Console.WriteLine("Constructor called from Shape"); 
        }

        public virtual void ShowArea()
        {
            Console.WriteLine("Calculation in progress ... ");
        }
    }
}
