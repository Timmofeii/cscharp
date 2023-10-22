/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
public class Program052
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[3][];
        arr[0] = new int[] { 1, 4, 7, 2 };
        arr[1] = new int[] { 5, 9, 2, 3 };
        arr[2] = new int[] { 8, 4, 2, 4 };
        AVGRowArray(arr);
    }

    public static void AVGRowArray(int[][] array)
    {
        global::System.Console.Write("Среднее арифметическое каждого столбца: ");
        for (int i = 0; i < array[0].Length; i++)
        {
            double avgColumn = 0;
            for (int j = 0; j < array.Length; j++)
            {
                avgColumn += array[j][i];
            }
            double result = Math.Round(avgColumn / array.Length, 2);
            Console.Write(result);
            if (i < array.Length)
            {
                global::System.Console.Write("; ");
            }
            else {
                global::System.Console.Write(".");
             }
        }
    }
}