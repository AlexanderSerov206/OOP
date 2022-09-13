using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Point : Figure
    {
        public Point(bool isVisible, Color color) : base(isVisible, color)
        {

        }

        public Point(bool isVisible, Color color, decimal x, decimal y) : base(isVisible, color, x, y)
        {

        }
    }
}
