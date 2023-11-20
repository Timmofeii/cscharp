/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */
using System;
public class Program60
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int[][][] array3D = Get3DArray(3, 3, 3);
        print3DArray(array3D);
    }
    public static void print3DArray(int[][][] array)
    {
        foreach (var item in array)
        {
            foreach (var item1 in item)
            {
                Console.WriteLine(string.Join("\t ", item1));

            }
            Console.WriteLine();


        }
    }
    public static int[][][] Get3DArray(int row, int col, int dip/*, int startArrValue, int endArrValue*/)
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

                    array[i][j][k] = countElement;
                    countElement++;
                    
                }


            }
        }



        return array;

    }
    public static int GetUniqueValue(int[][][] arr3D, int startArrValue, int endArrValue, int countElement)// нужно дописать и попробовать решить через  hashList, бо падает программа(((
    {
        int row = arr3D.Length;
        int col = arr3D[0].Length;
        int dip = arr3D[0][0].Length;
       
        if (endArrValue - startArrValue < row * col * dip)
        {

            throw new Exception("Массив не будет соответствовать условиям!");

        }

        Random rd = new Random();
        bool noRepeat = true;
        int value = 0;

        while (noRepeat)
        { int step = countElement;
           
            noRepeat = false;
            value = rd.Next(startArrValue, endArrValue);
            foreach (var arr2D in arr3D)
            {
                foreach (var arr1D in arr2D)
                {
                    foreach (var item in arr1D)
                    {
                        if (item == value)
                        {

                            noRepeat = true; break;
                        }
                        else if (countElement == 0)
                        {
                            value = rd.Next(startArrValue, endArrValue);
                            return value;
                        }
                        step--;
                       
                    }


                }

                
            }



        }
        return value;
    }
}


