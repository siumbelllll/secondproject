using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            string wWord = word.ToLower();
            bool palindrome = true;
            
            for (int i = 0; i < wWord.Length / 2; i++)
            {
                if (wWord[i] != wWord[wWord.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            Console.WriteLine();
            if (palindrome)
            {
                Console.WriteLine($"Слово является палиндромом!");
            }
            else
            {
                Console.WriteLine($"Слово НЕ является палиндромом.");
            }

        }
    }
}
