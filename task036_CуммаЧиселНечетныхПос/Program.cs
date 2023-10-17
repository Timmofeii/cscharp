/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
class Programm036
{
    public static void Main(string[] args)
    {
        int[] arr = new int[8];
        FullArrRandomNumbers(arr);
        System.Console.WriteLine(FindSummOddPositions(arr));
    }
    private static void FullArrRandomNumbers(int[] arr)
    {
        var rand = new Random();


        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(100, 1000);
        }
    }
    static int FindSummOddPositions(int[] arr)
    {
        int summOddPosition = 0;
        for (int i = 1; i < arr.Length; i += 2)
        { summOddPosition+=arr[i];

        }
        return summOddPosition;
    }
}