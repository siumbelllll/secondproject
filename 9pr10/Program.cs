using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            //1 добавляем 3 случайные строчные буквы
            for (int i = 0; i < 3; i++)
            {
                char lowercaseLetter = (char)('a' + random.Next(0, 26));
                sb.Append(lowercaseLetter);
            }
            // 2 добавляем 3 случайные цифры
            for (int i = 0; i < 3; i++)
            {
                char digit = (char)('0' + random.Next(0, 10));
                sb.Append(digit);
            }
            // 3 добавляем 2 случайные заглавные английские буквы
            for (int i = 0; i < 2; i++)
            {
                char uppercaseLetter = (char)('A' + random.Next(0, 26));
                sb.Append(uppercaseLetter);
            }

            // 4 gеремешиваем символы пароля 
            for (int i = sb.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }

            Console.WriteLine("Сгенерированный пароль: " + sb.ToString());
        }
    }
}
