/*37 Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предпоследний...
Результат запишите в новомо массиве
12345-583
6736-1210
*/
class Program037
{
    public static void Main(string[] args)
    {
        int[] arr = { 5, 4, 3, 4, 5 };// создали первый массив
        int[] arr1;// создали второй куда запишем сумму парных елементов 
        arr1 = ParrInArr(arr);
        System.Console.WriteLine(string.Join(" ", arr));//выводим в консоль массивы 

        System.Console.WriteLine(string.Join(" ", arr1));
    }
    private static int[] ParrInArr(int[] arr)
    {
        int remainder = arr.Length % 2;
        int arrLength = arr.Length / 2 + remainder;
        int[] newArr = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            if (i == arrLength - 1 && remainder == 1)// проверка чтобы работало с нечетным массивом 
            {
                newArr[i] = arr[i];
                continue;
            }
            newArr[i] = arr[i] *arr[arr.Length - i - 1];


        }
        return newArr;
    }
}