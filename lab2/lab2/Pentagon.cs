using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Pentagon : Figure
    {
        public double Side { get; set; }
        public double GetHeight()
        {
            return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));
        }
        public override double getArea()
        {
            return (Side * GetHeight() / 2) * 5;
        }
    }
}
