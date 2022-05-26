using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab3
{
    class Pentagon : Figure
    {
        public double Side { get; set; }

        public double GetHeight()
        {
            return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));
        }
        public override double GetArea()
        {
            return (Side * GetHeight() / 2) * 5;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + GetHeight() / 2), (int)(Position.Y + GetHeight() / 2));
        }
        public override void Draw(Graphics gr)
        {

            var points = new List<PointF>();

            for (int alpha = 0; alpha < 360; alpha++)
            {
                points.Add(new PointF(
                    (float)(GetCenter().X + GetHeight() * (Math.Cos(alpha * Math.PI / 180f))),
                    (float)(GetCenter().Y + GetHeight() * (Math.Sin(alpha * Math.PI / 180f)))
                ));
            }

            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.DrawPolygon(Pens.DarkCyan, points.ToArray());
            gr.SmoothingMode = SmoothingMode.None;

            // Рисуем информацию о координатах его центра
            gr.DrawString(GetCenter().ToString() + "\nArea: " + GetArea().ToString(),
                          new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
