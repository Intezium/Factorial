using System;

namespace Factorial
{
    class Program
    {
        static void Factorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("\nФакториал числа {0} равен {1}", number, factorial);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===>[Подсчет факториала]<===");
                Console.Write("\nВведите число: ");

                try
                {
                    int number = int.Parse(Console.ReadLine());

                    Factorial(number);
                }
                catch (FormatException) { Console.WriteLine("\nНекорректное число!"); }

                Console.WriteLine("\nEnter - Проверить еще");
                Console.WriteLine("Esc - Выйти");

                ConsoleKey inputKey = Console.ReadKey().Key;

                if (inputKey == ConsoleKey.Enter)
                    continue;
                else if (inputKey == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
