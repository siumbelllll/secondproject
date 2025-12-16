using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите почту: ");
            string email = Console.ReadLine();

            if (email.Contains("@"))
            {
                int Index = email.IndexOf('@');
                string maskedEmail = new string('*', Index) + email.Substring(Index);

                Console.WriteLine($"Исходный: {email}");
                Console.WriteLine($"Замаскированный: {maskedEmail}");
            }
            else
            {
                Console.WriteLine($"Email {email} не содержит символ '@'");
            }
        }
    }
}
