using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string number = Console.ReadLine();
            if (SplitIntoWords(number, out string first, out int Count))
            {
                Console.WriteLine($"Первое слово: {first}");
                Console.WriteLine($"Общее количество слов: {Count}");
            }
            else
            {
                Console.WriteLine("Ошибка: строка пуста, null или содержит только пробелы.");
            }
        }

        static bool SplitIntoWords(string text, out string Word, out int put)
        {
           Word = "";
            put = 0;

            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
               Word = words[0];
                put = words.Length;
                return true;
            }

            return false;
        }
    }
}
   
