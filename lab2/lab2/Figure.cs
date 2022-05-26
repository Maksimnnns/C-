using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public abstract class Figure
    {
        public string Name { get; set; }

        public abstract double getArea();
    }
}
