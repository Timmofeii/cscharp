/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
class Program38
{
    public static void Main(string[] args)
    {
        double[] arr = FullArrRandomNumbers(8, 1.0, 100.0);
        double result = DifferenceBetweenNumbers(arr);
        System.Console.WriteLine(result);
    }
    private static double[] FullArrRandomNumbers(int arrLength, double minimum, double maximum)
    {
        Random random = new Random();
        double[] arr = new double[arrLength];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.NextDouble() * (maximum - minimum) + minimum;

        }
        return arr;
    }
    private static double DifferenceBetweenNumbers(double[] arr)
    {
        int arrLength = arr.Length;
        double max = arr[0];
        double min = arr[arrLength - 1];
        for (int i = 1; i < arrLength; i++)
        {
//System.Console.WriteLine($"[{arr[i]}]");// разкомментируйте если хотите увидеть значения в массиве
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[arrLength - i] < min)
            {
                min = arr[arrLength - i];
            }
        }
        System.Console.WriteLine("Max: "+max);
        System.Console.WriteLine("Min: "+min);
        return max - min;
    }
}