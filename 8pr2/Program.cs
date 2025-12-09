using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк и столбцов : ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int sumGlav = 0, sumPoboch = 0;
            for (int i = 0; i < N; i++)
            {
                sumGlav += array[i, i];
                sumPoboch += array[i, N - 1 - i];
            }
            Console.WriteLine($"Сумма элементов главной диагонали: {sumGlav}");
            Console.WriteLine($"Сумма элементов побочной диагонали: {sumPoboch}");
        }
    }
}
