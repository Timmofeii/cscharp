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
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 4, 7, 2 };
        matrix[1] = new int[] { 5, 9, 2, 3 };
        matrix[2] = new int[] { 8, 4, 2, 4 };
        double[] arrNew = AVGRowArray(matrix);

        printMatrixDouble(matrix);
        PrintArr(arrNew);

    }
    private static void PrintArr(double[] arr)
    {
        /*System.Console.Write("[");  
        System.Console.Write(string.Join(", ",arr));// вывод через метод Join класа string 
        System.Console.Write("]");*/
        System.Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                System.Console.Write(", ");
            }

        }
        System.Console.Write("]");
    }

    public static double[] AVGRowArray(int[][] array)

    {
        int arrLengthRow = array[0].Length;
        double[] avgArr = new double[arrLengthRow];


        for (int i = 0; i < arrLengthRow; i++)
        {
            double avgRow = 0;
            for (int j = 0; j < array.Length; j++)
            {

                avgRow += array[j][i];
            }
            double result = Math.Round(avgRow / array.Length, 2);
            avgArr[i] = result;


        }
        return avgArr;
    }
    public static void printMatrixDouble(int[][] matrix)
    {

        for (int i = 0; i < matrix.Length; i++)
        {
            System.Console.Write("[");
            for (int j = 0; j < matrix[i].Length; j++)
            {


                System.Console.Write(" " + matrix[i][j]);

            }
            System.Console.WriteLine(" ]");


        }

    }
}