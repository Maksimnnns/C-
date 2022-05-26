using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    class Trapezoid : Figure
    {
        public double ABase { get; set; }
        public double BBase { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return ((ABase + BBase) / 2) * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Math.Max(ABase, BBase) / 2),
                             (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            // Опеределение координат вершин трапеции 
            Point[] points =
            {
                new Point(Position.X, Position.Y),
                new Point(Position.X, Position.Y + (int)Height),
                new Point(Position.X + (int)BBase, Position.Y + (int)Height),
                new Point(Position.X + (int)ABase, Position.Y),
                new Point(Position.X, Position.Y)
            };

            // Рисуем прямоугольную трапецию
            gr.DrawLines(new Pen(Color), points);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
