/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
class Program047
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter row array");
        int row = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter col array");
        int col = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter start doubele arr");
        double startArr = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter end doubele arr");
        double endArr = Convert.ToDouble(Console.ReadLine());
   


       // double[][] arr = CreateAndFullArr(row, col, startArr,endArr);
      

    }
    public static double[][] CreateAndFullArr(int row, int col, double startArr, double endArr)
    {
       double[][] arr = new double[row][];
        Random rd = new Random();
        for (int i = 0; i < row; i++)
        {
            arr[i] = new double[col];
            System.Console.Write("[");
            for (int j = 0; j < arr.Length; j++)
            {

                arr[i][j] =   Math.Round((rd.NextDouble() * (endArr - startArr) + startArr),2);

                System.Console.Write(" " + arr[i][j]);

            }
            System.Console.WriteLine(" ]");


        }
        return arr;
    }
}
