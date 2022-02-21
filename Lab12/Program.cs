using System;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные: х0, y0, x1, y1, R");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double radius = Convert.ToDouble(Console.ReadLine());

            double dlina = Circle.DlinaCircle(radius);
            double square = Circle.SquareCircle(radius);
            Console.WriteLine("Длина окружности равна {0}\nПлощадь окружности {1}", dlina, square);
            bool proverka;
            if (Circle.ProverkaTochki(x0, y0, x1, y1, radius) == true)
            {
                Console.WriteLine("Точка принадлежит поверхности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит поверхности");
            }

            Console.ReadKey();
        }
    }
}
