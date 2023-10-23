/* Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.*/
class Program039
{
    public static void Main(string[] args)
    {
        int[] arrStart = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        System.Console.WriteLine("arrStart [" + string.Join(" ",arrStart)+"]");

        ReversArr(arrStart);

        System.Console.WriteLine("arrStart [" + string.Join(" ",arrStart)+"]");

    }
    
    private static void ReversArr(int[] arr)
    {
        int arrLength = arr.Length;




        for (int i = 0; i <= arrLength / 2; i++)
        {
            int temp = arr[i];// записываем временную переменную
            arr[i] = arr[arrLength - i-1];
            arr[arrLength - i-1] = temp;


        }
        
    }
}
