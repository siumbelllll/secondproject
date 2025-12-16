using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    sb.AppendLine($"{i} x {j} = {i * j}");
                }
                sb.AppendLine();
            }
            Console.WriteLine("Таблица умножения от 1 до 5:");
            Console.WriteLine(sb.ToString());
        }
    }
}
