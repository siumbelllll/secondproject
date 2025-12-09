using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 3);
                }
            }
            Console.WriteLine("Крестики-нолики:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char symbol = ' ';
                    switch (array[i, j])
                    {
                        case 1:
                            symbol = 'X';
                            break;
                        case 2:
                            symbol = 'O';
                            break;
                        case 0:
                            symbol = '0';
                            break;
                    }
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
            int winner = 0; 

            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] != 0 && array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2])
                {
                    winner = array[i, 0];
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (array[0, j] != 0 && array[0, j] == array[1, j] && array[1, j] == array[2, j])
                {
                    winner = array[0, j];
                }
            }

            if (array[0, 0] != 0 && array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                winner = array[0, 0];
            }

            if (array[0, 2] != 0 && array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
            {
                winner = array[0, 2];
            }

            if (winner == 1)
                Console.WriteLine("Победили крестики");
            else if (winner == 2)
                Console.WriteLine("Победили нолики");
            else
                Console.WriteLine("Ничья или игра продолжается");
        }
    }
}