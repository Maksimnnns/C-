using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    class Parallelogram : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Base * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Base / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points =
            {
                new Point(Position.X, Position.Y),
                new Point((int)(Position.X + Height / 2), (int)(Position.Y + Height)),
                new Point((int)(Position.X + Height / 2 + Base), (int)(Position.Y + Height)),
                new Point((int)(Position.X + Base), Position.Y),
                new Point(Position.X, Position.Y),
            };

            gr.DrawLines(new Pen(Color), points);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
