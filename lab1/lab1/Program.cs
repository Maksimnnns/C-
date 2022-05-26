using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Слепцов Владислав");

            // Создадим комплексные числа и сразу присвоим значения
            // действительной и мнимой частям
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            // К числу a прибавим число b
            a.Add(b);

            // Из числа b вычтем число a
            b.Substract(a);

            // Умножим числа a на число b
            a.Multyply(b);

            // Разедлим число b на число a
            b.Divide(a);

            // Выводим результат
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            // Создание двух обектов
            Student st1 = new Student() { Name = "Влад", Gender = "Мужской", HairColor = "Черный", Age = 20 };
            Student st2 = new Student() { Name = "Юля", Gender = "Женский", HairColor = "Рыжий", Age = 19 };

            st1 = st1 + st2;

            Console.WriteLine("Имя: {0}\nПол: {1}\nЦвет волос: {2}\nВозраст: {3}", st1.Name, st1.Gender, st1.HairColor, st1.Age);
            Console.WriteLine("Имя: {0}\nПол: {1}\nЦвет волос: {2}\nВозраст: {3}", st2.Name, st2.Gender, st2.HairColor, st2.Age);
        }
    }
}
