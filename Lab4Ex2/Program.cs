using System;

namespace Lab4Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ex 2
            //Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
            //k.Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.

            // Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i
            //rezultatul.
            // Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
            //rezultatul.
            

            int n, m, k;

            Console.Write("Introdu marimea pt prima dimensiune: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introdu marimea pt a doua dimensiune: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Introdu marimea pt a treia dimensiune: ");
            k = int.Parse(Console.ReadLine());

            int[,,] matrix = new int[n, m, k];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        Console.Write("Intoduceti valorile pentru matrice[{0},{1},{2}]: ", i, j, l);
                        matrix[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Suma elementelor din matrice este: {0}", Sum3DMatrix(matrix));

            int max = MaxElement(matrix);
            Console.WriteLine("The maximum element in the matrix is: {0}", max);
        }
        static int Sum3DMatrix(int[,,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        sum += matrix[i, j, k];
                    }
                }
            }
            return sum;
        }


        static int MaxElement(int[,,] matrix)
        {
            int max = matrix[0, 0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        if (matrix[i, j, k] > max)
                        {
                            max = matrix[i, j, k];
                        }
                    }
                }
            }
            return max;
        }
    }
}