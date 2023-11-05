/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
public class Program044
{
    public static void Main(string[] args)
    {
        int N = 3;
        FibonacciNumbers(N);
    }
    private static void FibonacciNumbers(int number)
    {
        int[] arr = new int[number];
        int firstElement = 0;
        int secondElement = 1;
        for (int i = 0; i < number; i++)
        {
            if (i < 2)
            {
                arr[i] = i;
task            else
            {

                arr[i] = arr[firstElement] + arr[secondElement];
                firstElement++;
                secondElement++;
            }

        


        }

    }
}