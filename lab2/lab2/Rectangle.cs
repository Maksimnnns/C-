using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double getArea()
        {
            return Width * Height;
        }
    }
}
