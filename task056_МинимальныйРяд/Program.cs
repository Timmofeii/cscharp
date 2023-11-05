/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

class Program056
{
    public static void Main(string[] args)
    {
        int[][] arr = CreateAndFullArr(3, 3, 0, 10);
        int indexMinSum=FoundMinSumLineElements(arr);
        global::System.Console.WriteLine(indexMinSum);
    }
    public static int  FoundMinSumLineElements(int[][] arr)
    {
        int sumMinInd = 0;
        int minSum = Int32.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            int sumLine = 0;
            for (int j = 0; j < arr[i].Length; j++)
            {
                sumLine += arr[i][j];


            }
            if (sumLine < minSum)
            {
                minSum = sumLine;
                sumMinInd = i;
               
            }



        }return sumMinInd;
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
}

