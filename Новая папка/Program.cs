using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            string lengthput = Console.ReadLine();
            Console.Write("Введите ширину прямоугольника: ");
            string widthput = Console.ReadLine();
            if (double.TryParse(lengthput, out double lengt) && double.TryParse(widthput, out double widt))
            {
                if (lengt > 0 && widt > 0)
                {
                    double idea = CalculatePerimeter(lengt, widt);
                    Console.WriteLine($"Периметр прямоугольника: {idea:F}");
                }
                else
                {
                    Console.WriteLine("Длина и ширина должны быть положительными.");
                }
            }
            else { Console.WriteLine("некорректный ввод"); }

           


        }
        static double CalculatePerimeter(double leng, double put)
        {
            return 2 * (leng + put);
        }
    }
}
