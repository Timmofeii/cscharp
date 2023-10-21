﻿/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Aₘₙ = m+n. Выведите полученный массив на экран.*/
class Program048// не уверен что правильно понял условия задачи :-(
{
    public static void Main(string[] args)
    {
        int m = 3;//задайте размер m
        int n = 3;//задайте размер n
        int[][] arr = new int[3][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[3];
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = i + j;
            }

        }
        PrintArr(arr);
    }
    private static void PrintArr(int[][] arr)
    {
        foreach (var row in arr)
        {
            System.Console.WriteLine($"[{string.Join(" ", row)}]");
        }
    }

}