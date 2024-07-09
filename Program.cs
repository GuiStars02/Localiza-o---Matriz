using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o tamanho da sua matriz separado por um espaço: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine("Digite os números separados com um espaço: ");
            for (int i = 0; i < m; i++) {
                string[] array = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(array[j]);
                }
            }
            Console.WriteLine("Qual número você busca? ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados: ");
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {

                    if (mat[i, j] == number) {
                        Console.WriteLine($"Position {i},{j}:");

                        if (j > 0) {
                            Console.WriteLine("Left:" + mat[i, j - 1]);
                        }

                        if (j < n -1) {
                            Console.WriteLine("Right:" + mat[i, j + 1]);
                        }

                        if (i > 0) {
                            Console.WriteLine("Up:" + mat[i - 1, j]);
                        }

                        if (i < m - 1) {
                            Console.WriteLine("Down:" + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}