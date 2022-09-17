using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Rectangle : Point
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Area { get => Height * Width; }
        public Rectangle(bool isVisible, System.Drawing.Color color, double width, double height) : base(isVisible, color)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(bool isVisible, System.Drawing.Color color, decimal x, decimal y, double width, double height) : base(isVisible, color, x, y)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return base.ToString().Replace('.', ';') + $" Width: {Width}; Height: {Height}; Area: {Area}";
        }
    }
}
