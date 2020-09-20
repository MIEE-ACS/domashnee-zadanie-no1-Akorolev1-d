using System;

namespace Первая_программа
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим данные
            Console.WriteLine("Введите координаты первой точки(x1,y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки(x2,y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей точки(x3,y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            // Проверяем диапазон входящих данных
            if (Math.Abs(x1) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }

            if (Math.Abs(y1) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }

            if (Math.Abs(x2) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }

            if (Math.Abs(y2) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }

            if (Math.Abs(x3) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }
            if (Math.Abs(x1) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }
            if (Math.Abs(y3) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка! Диапазон");
                Environment.Exit(0);
            }


            // Выводим данные
            Console.WriteLine("Координаты точек:");
            Console.WriteLine($"Первая точка:");
            Console.Write($"x1:{Math.Round(x1, 3)}");
            Console.Write($"  y1:{Math.Round(y1, 3)}\n");

            Console.WriteLine($"Вторая точка:");
            Console.Write($"x2:{Math.Round(x2, 3)}");
            Console.Write($"  y2:{Math.Round(y2, 3)}\n");

            Console.WriteLine($"Третья точка:");
            Console.Write($"x3:{Math.Round(x3, 3)}");
            Console.Write($"  y3:{Math.Round(y3, 3)}\n");


            // Считаем длины отрезков
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine($"Длины отрезков:");
            Console.WriteLine($"a:{Math.Round(a, 3)}");
            Console.WriteLine($"b:{Math.Round(b, 3)}");
            Console.WriteLine($"c:{Math.Round(c, 3)}");


            // Считаем периметр и выводим данные в консоль
            double Perimeter = a + b + c;
            Console.WriteLine($"Perimeter:{Math.Round(Perimeter, 3)}");

            // Считаем площадь и выводим данные в консоль
            double HalfPerimetr = Perimeter / 2;
            double Area = Math.Sqrt(HalfPerimetr * (HalfPerimetr - a) * (HalfPerimetr - b) * (HalfPerimetr - c));
            Console.WriteLine($"Area:{Math.Round(Area, 3)}");
        }
    }
}
