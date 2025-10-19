using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string num = Console.ReadLine();
            Console.Write("Введите величину увеличения: ");
            string num1 = Console.ReadLine();  
            if (int.TryParse(num, out int numder)&& int.TryParse(num1,out int numder2 ))
            {
                if (numder >= 0)
                {
                    Console.WriteLine($"До увелечения: {numder}");
                    IncreaseNumber(ref numder, ref numder2);
                    Console.WriteLine($"После увелечения: {numder}");

                }
                else {
                    Console.WriteLine("Число должно быть не меньше 0.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            
            
         


        }
       static  void IncreaseNumber(ref int nume, ref int nu)
        {
            nume += nu;
        }
    }
}
