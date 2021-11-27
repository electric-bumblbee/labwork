using System;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 Задание 2 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Введите диамер окружности ");
            int d = Convert.ToInt32(Console.ReadLine());

            double L = 3.14 * d;

            Console.WriteLine($"Длина окружности равна {L}");

            Console.ReadKey();
        }
    }
}
