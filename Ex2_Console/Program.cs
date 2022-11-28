using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                Console.Write("Введите целое число для проверки на четность: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();

            Console.Write("Число является: ");

            // Проверка на четность
            string result = number % 2 == 0 ? "четным" : "нечетным";

            Console.WriteLine(result);
        }
    }
}
