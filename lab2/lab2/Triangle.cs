using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Triangle : Figure
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double getArea()
        {
            return Height * Base / 2;
        }
    }
}
