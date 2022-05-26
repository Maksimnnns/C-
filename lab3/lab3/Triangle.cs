using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    class Triangle : Figure
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double GetArea()
        {
            return Height * Base / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Base / 2), (int)(Position.Y + Base / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points =
            {
                new Point(Position.X, Position.Y),
                new Point(Position.X, Position.Y + (int)Height),
                new Point(Position.X + (int)Base, Position.Y + (int)Height),
                new Point(Position.X, Position.Y),
            };
            // Рисуем треугольник
            gr.DrawLines(new Pen(Color), points);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(), 
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
