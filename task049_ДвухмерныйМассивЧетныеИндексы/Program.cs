/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/
class Program049
{
    public static void Main(string[] args)
    {
        int[][] arrOrigin = CreateAndFullArr(3, 3, 0, 10);
        int[][] newArr = WorkOnlyDoublesIndex(arrOrigin);
    }
    public static int[][] WorkOnlyDoublesIndex(int[][] arr)
    {
        int[][] arrNewforeach = arr;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j <arr[i].Length; j++)
            {
              if (i%2==0&&j%2==0){
                arr[i][j]= arr[i][j]*arr[i][j];
              }
              System.Console.Write(arr[i][j]+" ");

            }
            System.Console.WriteLine();

        }
        return arrNewforeach;
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