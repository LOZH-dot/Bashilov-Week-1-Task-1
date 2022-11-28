using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = 0;

            while (true)
            {
                Console.Write("Введите периметр равностороннего треугольника (p): ");
                try
                {
                    p = double.Parse(Console.ReadLine());

                    if (p < 0) throw new Exception("Значение периметра не может быть меньше нуля!");
                    if (p == 0) throw new Exception("Значение периметра не может быть равным нулю!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine($"{ex.Message}");
                }
            }

            // Получаем сторону равностороннего треугольника
            double a = p / 3;

            Console.WriteLine();

            Console.Write("Площадь треугольника равна (округлено до 2-х знаков после запятой): ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.Round(((a * a) * Math.Sqrt(3)) / 4, 2));
            Console.ResetColor();
        }
    }
}
