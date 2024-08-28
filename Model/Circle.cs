using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Model
{
    public class Circle : Shape
    {
        public Circle() {
            Console.WriteLine("Constructor called from Circle");
        }

        public override void ShowArea()
        {
            base.ShowArea();

            var area = 3.1415 * base.Radius * base.Radius;
            Console.WriteLine($"The area of cirlce is {area}");
        }
    }
}
