/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.*/
class Program051
{
    public static void Main(string[] args)
    {
        int[][] arr = CreateAndFullArr(3, 3, 1, 10);
        int sumDiagonal=FindSumDiagonal(arr);
        Console.WriteLine(sumDiagonal);
    }
    private static int FindSumDiagonal(int[][] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (i == j) { sum += arr[i][j]; }


            }
        }
        return sum;
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