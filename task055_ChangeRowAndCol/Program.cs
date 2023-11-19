/*55.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7*/
using System;
public class Program055
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int[][] arr = CreateAndFullArr(3, 2, 0, 10);
        int[][] arr2 = ChangeRowOnLine(arr);
        print2DArray(arr2);
    }
    public static int[][] ChangeRowOnLine(int[][] array)
    {
        int row = array.Length;
        int col = array[0].Length;
        if (row != col)
        {
            throw new Exception("Сообщение для пользователя");

        }
        int[][] localArray = new int[row][];
        for (global::System.Int32 i = 0; i < localArray.Length; i++)
        {
            localArray[i] = new int[col];
            localArray[i][0] = array[0][i];
            localArray[0][i] = array[i][0];
            for (global::System.Int32 j = 1; j < localArray.Length; j++)
            {
                if (i != 0)
                {
                    localArray[i][j] = array[i][j];
                }
            }




        }

        return localArray;
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
    public static void print2DArray(int[][] array)
    {

        foreach (var item1 in array)
        {
            Console.WriteLine(string.Join(" ", item1));

        }
        Console.WriteLine();



    }

}