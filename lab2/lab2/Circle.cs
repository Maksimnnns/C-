using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
