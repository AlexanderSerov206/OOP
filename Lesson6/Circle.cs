using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Circle : Point
    {
        public double Radius { get; private set; }
        public double Area { get => Math.PI * Math.Pow(Radius, 2); }
        public Circle(bool isVisible, System.Drawing.Color color, double radius) : base(isVisible, color)
        {
            Radius = radius;
        }

        public Circle(bool isVisible, System.Drawing.Color color, decimal x, decimal y, double radius) : base(isVisible, color, x, y)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return base.ToString().Replace('.', ';') + $" Radius: {Radius}; Area: {Area}.";
        }
    }
}
