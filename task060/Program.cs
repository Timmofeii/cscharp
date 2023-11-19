/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */
using System;
public class Program60
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int[][][] array3D = Get3DArray(3, 3, 3, 0, 100);
        print3DArray(array3D);
    }
    public static void print3DArray(int[][][] array)
    {
        foreach (var item in array)
        {
            foreach (var item1 in item)
            {
                Console.WriteLine(string.Join(" ", item1));

            }
            Console.WriteLine();


        }
    }
    public static int[][][] Get3DArray(int row, int col, int dip, int startArrValue, int endArrValue)
    {
        int countElement = 0;
        Random rd = new Random();
        int[][][] array = new int[row][][];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[col][];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = new int[dip];

                for (int k = 0; k < array[i][j].Length; k++)
                {

                    array[i][j][k] = GetUniqueValue(array, startArrValue, endArrValue, countElement);
                    countElement++;
                }


            }
        }



        return array;

    }
    public static int GetUniqueValue(int[][][] array, int startArrValue, int endArrValue, int countElement)
    {
        int row = array.Length;
        int col = array[0].Length;
        int dip = array[0][0].Length;
        int step = 0;
        if (endArrValue - startArrValue < row * col * dip)
        {

            throw new Exception("Массив не будет соответствовать условиям!");

        }

        Random rd = new Random();
        bool noRepeat = true;
        int value = 0;
        do
        {
            noRepeat = false;
            value = rd.Next(startArrValue, endArrValue);
            foreach (var item in array)
            {
                foreach (var item1 in item)
                {
                    foreach (var item2 in item1)
                    {
                        if (countElement == 0)
                        {
                            return value;
                        }
                        if (item2 == value) noRepeat = true;
                    }

                }

            }
        } while (!noRepeat);


        return value;
    }
}


