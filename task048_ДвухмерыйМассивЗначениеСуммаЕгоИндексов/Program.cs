﻿/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Aₘₙ = m+n. Выведите полученный массив на экран.*/
class Program048// не уверен что правильно понял условия задачи :-(
{
    public static void Main(string[] args)
    {
        FullArrInSumHisIndex();
    }
    private static void FullArrInSumHisIndex()
    {
        int[][] arr = new int[3][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[3];
            System.Console.Write("[ ");
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = i + j;
                System.Console.Write(arr[i][j]+" ");

            }
            System.Console.WriteLine("]");

        }
    }
}