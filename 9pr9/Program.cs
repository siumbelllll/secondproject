using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на английском языке (строчные буквы) : ");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char letter in word)
            {
                int position = letter - 'a';
                position = position + 3;
                if (position >= 26)
                {
                    position = position - 26; 
                }
                char a = Convert.ToChar('a' + position);
                sb.Append(a);
            }

            Console.WriteLine($"Зашифрованное слово: {sb}");


        }
    }
}
