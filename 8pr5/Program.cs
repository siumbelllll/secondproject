using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr5
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

            Console.WriteLine("Седловые точки:");

                bool found = false;

            for (int i = 0; i < 4; i++) 
            {
                int min1 = array[i, 0];
                int min2 = 0;

                for (int j = 1; j < 4; j++)
                {
                    if (array[i, j] < min1)
                    {
                        min1 = array[i, j];
                        min2 = j;
                    }
                }

                bool Max = true;
                for (int k = 0; k < 4; k++)
                {
                    if (array[k, min2] > min1)
                    {
                        Max = false;
                        break;
                    }
                }

                if (Max)
                {
                    Console.WriteLine($"[{i},{min2}] = {min1}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Седловых точек нет");
        }
    }
}
