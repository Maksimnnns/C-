using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        // Сложение
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        // Вычитание
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        // Умножение
        public void Multyply(Complex x)
        {
            Real =  Real * x.Real - Imag * x.Imag;
            Imag = Real * x.Imag + Imag * x.Real;
        }

        // Деление
        public void Divide(Complex x)
        {
            Real = ( Real * x.Real + Imag * x.Imag ) / ( Math.Pow(x.Real, 2) + Math.Pow(x.Imag, 2) );
            Imag = ( x.Real * Imag - Real * x.Imag ) / ( Math.Pow(x.Real, 2) + Math.Pow(x.Imag, 2) );
        }
    }
}
