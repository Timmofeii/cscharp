/* Задайте двумерный массив размером m×n, заполненный случайными целыми числами.*/
class Program046
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter row array");
        int row = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter col array");
        int col = Convert.ToInt32(Console.ReadLine());
     CreateAndFullArr(row,col,1,10);
        
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