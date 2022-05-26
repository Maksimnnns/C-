using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    class Program
    {
        

        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат №1",
                Color = Color.Black,
                Position = new Point(30, 30),
                Width = 50,
                Height = 50,
            },
            new Rectangle()
            {
                Name = "Квадрат №2",
                Color = Color.Red,
                Position = new Point(120, 30),
                Width = 30,
                Height = 30,
            },
            new Rectangle()
            {
                Name = "Прямоугольник №1",
                Color = Color.Indigo,
                Position = new Point(230, 30),
                Width = 150,
                Height = 50,
            },
            new Circle()
            {
                Name = "Круг",
                Color = Color.Aqua,
                Position = new Point(250, 250),
                Radius = 80,
            },
            new Triangle()
            {
                Name = "Треугольник",
                Color = Color.Purple,
                Position = new Point(500, 250),
                Base = 120,
                Height = 60,
            },
            new Trapezoid()
            {
                Name = "Трапеция",
                Color = Color.Yellow,
                Position = new Point(350, 250),
                ABase = 60,
                BBase = 100,
                Height = 70,
            },
            new Rhombus()
            {
                Name = "Ромб",
                Color = Color.Red,
                Position = new Point(650, 250),
                Diagonal1 = 80,
                Diagonal2 = 160,
            },
            new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = Color.Orchid,
                Position = new Point(250, 50),
                Height = 80,
                Base = 160,
            },
            new Pentagon()
            {
                Name = "Правильный пятиугольник",
                Color = Color.Black,
                Position = new Point(150, 400),
                Side = 60,
            },
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3 - Полиморфизм");
            Console.WriteLine("Выполнил - Слепцов Владислав");

            Form frm = new Form()
            {
                Text = "Лабораторная работа №3 - Полиморфизм",
                Size = new Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
