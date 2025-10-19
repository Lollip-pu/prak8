using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string num = Console.ReadLine();
            Console.Write("Введите минимальную строку: ");
            string min = Console.ReadLine();
            if (string.IsNullOrEmpty(num))
            {
                Console.WriteLine("Ошибка: строка не может быть пустой или null ");
                return;
            }
            if (int.TryParse(min, out int minim))
            {
                if (minim > 0)
                {
                    bool longs = IsStringLongEnough(num, minim);
                    Console.WriteLine($"строка '{num}' {(longs ? "соответствует" : "не соответствует")} минимальной длине.");
                }
                else
                {
                    Console.WriteLine("Минимальная строка должна быть больше 0");

                }
            }
            else
            {
                Console.WriteLine("Некорретный ввод");
            }
           
        }
       static  bool IsStringLongEnough(string text, int mini)
        {
            return text.Length >= mini;
        }
    }
}
