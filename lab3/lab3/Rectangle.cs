using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace lab3
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            // Рисуем прямоугольник
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Width, (int)Height);

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
