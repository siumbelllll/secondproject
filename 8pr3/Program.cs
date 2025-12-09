using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, M];
            Random random = new Random();
            Console.WriteLine($"Исходный массив ({N}x{M}):");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] transposed = new int[M, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                  transposed[j, i] = array[i, j];
                }
            }
            Console.WriteLine($"Транспонированный массив ({M}x{N}):");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(transposed[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
