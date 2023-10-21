/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
class Program050
{
    public static void Main(string[] args)
    {
        int[][] arr = {
       new int[] {0,1,2},
       new int[] {3,4,5},
       new int[]{6,7,8}
       };
        ToPrint(arr);
        bool isTrue = CheckValue(arr, 10);
        System.Console.WriteLine((isTrue) ? "There value" : "No have value");
    }
    public static bool CheckValue(int[][] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == value)
                {
                    return true;

                }


            }
            

        }return false;
       }
        public static void ToPrint(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("[ ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine("]");
            }
        }
}