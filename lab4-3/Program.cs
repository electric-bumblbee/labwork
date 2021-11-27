using System;

namespace lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 Задание 3 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int S = (a + b)/2;

            Console.WriteLine($"Среднее арифметическое a и b равно {S}");

            Console.ReadKey();
        }
    }
}
