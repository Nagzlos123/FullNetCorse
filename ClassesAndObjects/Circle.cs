using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Circle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public void CircleArea()
        {
            var result = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Circle area: {result}");
        }

        public void CircleCircumference()
        {
            var result = 2* Math.PI * Radius;
            Console.WriteLine($"Circle circumference: {result}");
        }
    }
}
