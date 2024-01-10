using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDoubleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            int n = N - 1;
            int z = 0;
            int x = 0;
            int[,] A = new int[N, N]
            {
                { 1, 2, 20, 14, 22 },
                { 6, 7, 11, 12, 10},
                { 13, 4, 16, 21, 3},
                { 9, 15, 19, 18, 5},
                { 24, 17, 25, 8, 23}
            };


            for (int a = 0; a < N * N; a++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (z < A[i, j])
                        {
                            z = A[i, j];
                            for (int k = 0; k < n+1; k++)
                            {
                                for (int h = 0; h < n+1; h++)
                                {
                                    if (A[n - k, n - h] <= z)
                                    {
                                        x = A[n - k, n - h];
                                        A[n - k, n - h] = z;
                                        A[i, j] = x;
                                        z = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
