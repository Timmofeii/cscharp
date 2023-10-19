/*31.Задайте массив из 12 элементов,
 заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.*/
public class Program031
{
    public static void Main(string[] args)
    {
        int[] arr = FullAndPrintArr(4, -10, 10);
        int summPos = SummPosOrNegElements(arr, 1);
        int summNeg = SummPosOrNegElements(arr, -1);


        System.Console.WriteLine($"sumPos: {summPos} sumNeg: {summNeg}");
    }
    private static int SummPosOrNegElements(int[] arr, int posOrNeg)
    {//чтобы получить сумму позитивных даем методу позитивное число
     // для получения суммы отрицательных даем отрицательное цисло 
        int resultPositive = 0;
        int resultNegative = 0;
        foreach (var item in arr)
        {

            if (item > 0) { resultPositive += item; }
            else
            {
                resultNegative += item;
            }
        }
        if (posOrNegative == 1)
        {
            return resultPositive;
        }
        return resultNegative;
    }
    private static int[] FullAndPrintArr(int lenght, int userStart, int userEnd)
    {
        int[] arr = new int[lenght];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(userStart, userEnd);


        }

        PrintArr(arr);
        return arr;
    }
    private static void PrintArr(int[] arr)
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
        System.Console.WriteLine("]");
    }
}