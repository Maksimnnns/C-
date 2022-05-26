using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Decagon : Figure
    {
        public double Side { get; set; }
        public override double getArea()
        {
            return 5 * Math.Pow(Side, 2) / 2 * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
