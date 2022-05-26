using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Trapezoid : Figure
    {
        public double ABase { get; set; }
        public double BBase { get; set; }
        public double Height { get; set; }
        public override double getArea()
        {
            return ((ABase + BBase) / 2) * Height;
        }
    }
}
