using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число n (0-20): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n))
            {
                if (n >= 0 && n <= 20)
                {
                    long factorial = CalculateFactorial(n);
                    Console.WriteLine($"{n}! = {factorial}");
                }
                else
                {
                    Console.WriteLine("Ошибка: число должно быть в диапазоне от 0 до 20.");
                }
            }
            else
            {
                Console.WriteLine("некорректный ввод.");
            }
        }

        static long CalculateFactorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
       
