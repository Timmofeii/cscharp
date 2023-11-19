/*53.Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2*/
using System;
class Program053
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int[][] array = CreateAndFullArr(3, 3, 0, 10);

        ChangeArray(array);
        print3DArray(array);
    }
    public static int[][] ChangeArray(int[][] array)
    {
        int lastLineInd = array.Length - 1;
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                int temp = array[i][j];
                array[i][j] = array[lastLineInd][j];
                array[lastLineInd][j] = temp;


            }


        }
        return array;
    }
    public static int[][] CreateAndFullArr(int row, int col, int startArr, int endArr)
    {
        int[][] arr = new int[row][];
        Random rd = new Random();
        for (int i = 0; i < row; i++)
        {
            arr[i] = new int[col];
            System.Console.Write("[");
            for (int j = 0; j < arr.Length; j++)
            {

                arr[i][j] = rd.Next(startArr, endArr);
                System.Console.Write(" " + arr[i][j]);

            }
            System.Console.WriteLine(" ]");


        }
        return arr;
    }
    public static void print3DArray(int[][] array)
    {

        foreach (var item1 in array)
        {
            Console.WriteLine(string.Join(" ", item1));

        }
        Console.WriteLine();



    }
}