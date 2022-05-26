using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lab3
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius / 2), (int)(Position.Y + Radius / 2));
        }
        public override void Draw(Graphics gr)
        {
            // Рисуем круг
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (int)Radius, (int)Radius);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
