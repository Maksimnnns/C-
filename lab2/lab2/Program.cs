using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнил - Слепцов Владислав");

            // Определим два прямоугольника А и Б и на месте зададим их параметры
            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник А",
                Width = 15.2,
                Height = 24.5
            };
            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник Б",
                Width = 5.2,
                Height = 36.5
            };

            // Определение круга и его параметров
            Circle fig1 = new Circle()
            {
                Name = "Круг",
                Radius = 4
            };

            // Определение трегольника и его параметров
            Triangle fig2 = new Triangle()
            {
                Name = "Треугольник",
                Base = 6.3,
                Height = 5.5
            };

            // Оперделение трапеции и ее параметров
            Trapezoid fig3 = new Trapezoid()
            {
                Name = "Трапеция",
                ABase = 6.1,
                BBase = 12.2,
                Height = 5
            };

            // Определение ромба и его параметров
            Rhombus fig4 = new Rhombus()
            {
                Name = "Ромб",
                Base = 15.3,
                Height = 4.1
            };

            // Оперделение параллелограмма и его параметров
            Parallelogram fig5 = new Parallelogram()
            {
                Name = "Параллелограмм",
                Base = 48.7,
                Height = 1523.6
            };

            // Определение правильного пятиугольника и его параметров
            Pentagon fig6 = new Pentagon()
            {
                Name = "Правильный пятиугольник",
                Side = 7
            };

            // Оперделение правильного десятиугольника и его параметров
            Decagon fig7 = new Decagon()
            {
                Name = "Правильный десятиугольник",
                Side = 13
            };

            // Вывод информации о прямоугольниках
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig1.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig1.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig2.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig2.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig3.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig3.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig4.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig4.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig5.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig5.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig6.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig6.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", fig7.Name);
            Console.WriteLine("Площадь фигуры: {0}", fig7.getArea());
        }
    }
}
