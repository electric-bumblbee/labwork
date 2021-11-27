using System;

namespace lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 Задание 5 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите число а ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b ");
            double b = Convert.ToDouble(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            double summa = a + b;
            double raznost = a - b;
            double proizvedenie = a * b;
            double chastn = a / b;

            Console.WriteLine($"Сумма модудей чисел равна {summa}");
            Console.WriteLine($"Разность модудей чисел равна {raznost}");
            Console.WriteLine($"Произведение модудей чисел равно {proizvedenie}");
            Console.WriteLine($"Частное модудей чисел равно {chastn}");

            Console.ReadKey();
        }
    }
}
