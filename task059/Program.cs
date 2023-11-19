/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
*/


using System;
using System.Collections.Generic;
using System.Text;
public class Program059
{
    public static void Main(string[] args)
    {
        Console.Clear();

        /*  int userArrayRow = TakeEnteredNumber("Введите количество строк:");
          int userArrayColumn = TakeEnteredNumber("Введите количество столбцов:");
          int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
          int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");*/
        int[,] user2DArray = GetRandom2DArray(3, 3, 0, 10);

        Print2DArray(user2DArray);
        int[] userMinIndex = FindMinIndex(user2DArray);
        int[] minInd = FindMinIndex(user2DArray);
        int deleteRow = minInd[0];
        int deleteCol = minInd[1];

        int[,] userDeletedArray = DeleteRowAndColumn(user2DArray, deleteRow, deleteCol);
        System.Console.WriteLine("");
        Print2DArray(userDeletedArray);


    }




    static int TakeEnteredNumber(string message)
    {
        System.Console.WriteLine(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }


    static int[,] GetRandom2DArray(int start, int end, int row, int column)
    {
        int[,] array = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = new Random().Next(start, end);
                

            }
        }
        return array;
    }


    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }


    public static int[] FindMinIndex(int[,] array)
    {
        int[] delete = { 0, 0 };
        int min = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    delete[0] = i;
                    delete[1] = j;
                }

            }
        }
        return delete;
    }



    public static int[,] DeleteRowAndColumn(int[,] array, int deleteRow, int deleteCol)
    {
        int lengthRow = array.GetLength(0);
        int lengthCol = array.GetLength(1);

        int[,] result = new int[lengthRow - 1, lengthCol - 1]; // Создаем новый массив на одну строку и столбец меньше

        int newRow = 0;
        for (int i = 0; i < lengthRow; i++)
        {
            if (i != deleteRow)
            {
                int newCol = 0;
                for (int j = 0; j < lengthCol; j++)
                {
                    if (j != deleteCol)
                    {
                        global::System.Console.Write($" nr:{newRow} nc:{newCol} i:{i} j:{j}");
                        result[newRow, newCol] = array[i, j];
                        newCol++;
                    }
                }
                newRow++;
                global::System.Console.WriteLine();
            }
        }

        return result;
    }






}