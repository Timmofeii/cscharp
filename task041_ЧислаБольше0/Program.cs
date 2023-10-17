/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
public class Program041
{
    public static void Main(string[] args)
    {
        int[] arr = UserNumbers(8);
int count=HowMuchIsPositive(arr);
System.Console.WriteLine(string.Join(" ",arr));
System.Console.WriteLine(count);
    }
    private static int HowMuchIsPositive(int []arr){
        int count =0;
        for (int i = 0; i < arr.Length; i++)
        {if(arr[i]>0){
            count++;
        }
          
        }  return count;
    }
    private static int[] UserNumbers(int arrLength)
    {
        int[] arr = new int[arrLength];
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write("Enter number " + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());


        }
        return arr;
    }
}