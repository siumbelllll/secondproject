using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "+79161234567";
            
            string a = phone.Substring(0, 2);  
            string b = phone.Substring(2, 3); 
            string c = phone.Substring(5, 3);     
            string d = phone.Substring(8, 2);    
            string e = phone.Substring(10, 2);

            string changedPhone = $"{a} ({b}) {c}-{d}-{e}";
           
            Console.WriteLine($"Исходный номер: {phone}");
            Console.WriteLine($"Форматированный номер: {changedPhone}");

        }
    }
}
