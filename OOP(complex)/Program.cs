using System;

namespace OOP_complex_
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex();

            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = double.Parse(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго комплексного числа: ");
            double i2 = double.Parse(Console.ReadLine());

            Console.Write("Сложение: ({0} + {1}i) + ({2} + {3}i) = ", r1, i1, r2, i2);
            complex.Addition(r1, i1, r2, i2);

            Console.Write("Умножение: ({0} + {1}i) * ({2} + {3}i) = ", r1, i1, r2, i2);
            complex.Multiplication(r1, i1, r2, i2);
        }
    }

    public class Complex
    {
        public double real;
        public double imaginary;

        public void Addition(double a, double bi, double c, double di)
        {
            real = a + c;
            imaginary = bi + di;

            Console.WriteLine("{0} + {1}i", real, imaginary);
        }

        public void Multiplication(double a, double bi, double c, double di)
        {
            real = (a * c) - (bi * di);
            imaginary = (a * di) + (bi * c);

            Console.WriteLine("{0} + {1}i", real, imaginary);
        }
    }
}
