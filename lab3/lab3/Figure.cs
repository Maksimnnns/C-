using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Point Position { get; set; }
        public abstract double GetArea();
        public abstract Point GetCenter();
        public abstract void Draw(Graphics gr);
    }
}
