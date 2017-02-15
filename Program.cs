using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задачи_о_прямоугольном_треугольнике
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 7;
            double c, s;
            Console.WriteLine("Решение задачи на нахождение гипотенузы прямоугольного треугольника по двум известным катетам с использованием теоремы Пифагора");
            Console.WriteLine("Введите длину первого катета:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Известны катеты а = " + a + "м;   b = " + b + "м");
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Найдём гипотенузу: с = " + string.Format("{0:0.00}", c) + "м");
            s = 0.5 * a * b;
            Console.WriteLine("Теперь найдём площадь: s = " + s + "м2");
            Console.ReadKey();

        }
    }
}