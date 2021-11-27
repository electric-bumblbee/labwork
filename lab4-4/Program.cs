using System;

namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 Задание 4 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите число а ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b ");
            int b = Convert.ToInt32(Console.ReadLine());

            double A = Math.Pow(a, 2);
            double B = Math.Pow(b, 2);

            double summa = A + B;
            double raznost = A - B;
            double proizved = A * B;
            double chactn = A / B;

            Console.WriteLine($"Сумма чисел равна {summa} ");
            Console.WriteLine($"Разность чисел равна {raznost} ");
            Console.WriteLine($"Произведение чисел рвно {proizved} ");
            Console.WriteLine($"Частное чисел равно {chactn} ");

            Console.ReadKey();
        }
    }
}
