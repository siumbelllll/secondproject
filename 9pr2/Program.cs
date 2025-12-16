using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _9pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# это современный язык программирования.";
            Console.WriteLine(text);

            int countSymbol = text.Length;
            Console.WriteLine($"Общее количество символов в строке: {countSymbol} ");

            string[] textArray = text.Split(' ');
            int countWords = textArray.Length;
            Console.WriteLine($"Количестов слов в строке: {countWords}");

            int index = text.IndexOf("язык");
            Console.WriteLine($"Индекс слова язык в строке: {index}");

            bool starts = text.StartsWith("C#");
            Console.WriteLine($"Начинается ли текст с C#?: {starts} ");


        }
    }
}
