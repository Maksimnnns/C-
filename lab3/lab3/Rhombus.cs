using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    class Rhombus : Figure
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }
        public override double GetArea()
        {
            return Diagonal1 * Diagonal2 / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Diagonal1 / 2), (int)(Position.Y + Diagonal2 / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points =
            {
                new Point(Position.X + (int)(Diagonal1 / 2), Position.Y),
                new Point(Position.X + (int)Diagonal1, Position.Y + (int)(Diagonal2 / 2)),
                new Point(Position.X + (int)(Diagonal1 / 2), Position.Y + (int)Diagonal2),
                new Point(Position.X, Position.Y + (int)(Diagonal2 / 2)),
                new Point(Position.X + (int)(Diagonal1 / 2), Position.Y)
            };

            // Рисуем ромб
            gr.DrawLines(new Pen(Color), points);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
