using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "яблоко, банан , апельсин,киви, груша";
            Console.WriteLine($"Исходная строка: {fruits} ");
            string[] fruitsArray = fruits.Split(',');

            for (int i = 0; i < fruitsArray.Length; i++)
            {
                fruitsArray[i] = fruitsArray[i].Trim();
            }
 
            Array.Sort(fruitsArray);
            string result = string.Join("; ", fruitsArray);

            Console.WriteLine($"Итоговый результат: {result}");
        }
    }
}
