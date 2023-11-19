/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */
using System;
public class Program58
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int[][] firstMatrix = CreateAndFullArr(3, 3, 0, 10);
        int[][] secondMatrix = CreateAndFullArr(3, 3, 0, 10);

        int[][] thirdMatrix = ProductOfTwoMatrices(firstMatrix, secondMatrix);
        PrintMatrix(thirdMatrix);
    }
    public static void PrintMatrix(int[][] array)
    {
        foreach (var item in array)
        {
            global::System.Console.WriteLine(string.Join(" ", item));
        }
    }
    public static int[][] ProductOfTwoMatrices(int[][] matrixA, int[][] matrixB)
    {
        int[][] matrixC;
        int row = matrixA.Length;
        int col = matrixB[0].Length;

        if (matrixA[0].Length == matrixB.Length)
        {
            matrixC = new int[row][];

            for (int i = 0; i < matrixC.Length; i++)
            {
                matrixC[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    int count = 0;
                    for (int k = 0; k < matrixA[0].Length; k++)
                    {
                        count += matrixA[i][k] * matrixB[k][j];
                    }
                    matrixC[i][j] = count;
                }
            }
        }
        else
        {
            Console.WriteLine("Количество столбцов в первой матрице не равно количеству строк во второй матрице.");
            return null;
        }

        return matrixC;
    }
    public static int[][] CreateAndFullArr(int row, int col, int startArr, int endArr)
    {
        int[][] arr = new int[row][];
        Random rd = new Random();
        for (int i = 0; i < row; i++)
        {
            arr[i] = new int[col];
            System.Console.Write("[");
            for (int j = 0; j < arr[i].Length; j++)
            {

                arr[i][j] = rd.Next(startArr, endArr);
                System.Console.Write(" " + arr[i][j]);

            }
            System.Console.WriteLine(" ]");


        }
        return arr;
    }
}