using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Rhombus : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double getArea()
        {
            return Base * Height;
        }
    }
}
