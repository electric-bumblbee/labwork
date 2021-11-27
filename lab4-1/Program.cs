using System;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 Задание 1(＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите значение стороны а");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение стороны b");
            int b = Convert.ToInt32(Console.ReadLine());

            int P = 2 * (a + b);
            int S = a * b;

            Console.WriteLine($"Площадь прамоугольника равна {S}");
            Console.WriteLine($"Периметр прямоугольника равен {P}");

            Console.ReadKey();
        }
    }
}
