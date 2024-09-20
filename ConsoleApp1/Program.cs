using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace ConsoleApp1
{
    internal class Program
    {
        class Dvaarray
        {
            public double[,] A = new double[2, 3];
            public double[,] B = new double[2, 3];
            public int kol_string;
            public int kol_stolb;

            public void FillingArrage()
            {
                Random random = new Random();
                for(int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j ++)
                    {
                        A[i, j] = random.Next(1,5) + random.NextDouble();
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B[i, j] = random.Next(1,5) + random.NextDouble();
                    }
                }
            }

            public void Add()
            {
                Console.WriteLine("Сложение");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.Write(Math.Round(A[i, j] + B[i,j],2) + " ");
                        
                    }
                    Console.WriteLine();
                }
            }
            public void Multiplication()
            {
                Console.WriteLine("Умножение");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.Write(Math.Round(A[i, j] * B[i, j],2) + " ");

                    }
                    Console.WriteLine();
                }
            }
            public void MultiplicationNumber() 
            {
                Console.WriteLine("Умножение на число");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.Write(Math.Round(A[i, j] * 2, 2) + " ");
                        
                    }
                    Console.WriteLine();
                }
            }
            public void PrintArrage() 
            {
                Console.WriteLine("Вывод матрицы");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.Write(Math.Round(A[i, j], 2) + " ");

                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Dvaarray dvaarray = new Dvaarray();    

           dvaarray.FillingArrage(); /*заполнение матрицы*/

            dvaarray.Add(); /*сложение*/

            dvaarray.Multiplication(); /*умножение*/

            dvaarray.MultiplicationNumber(); /*умножение на число*/

            dvaarray.PrintArrage(); /*вывод мтрицы */
        }
    }
}
