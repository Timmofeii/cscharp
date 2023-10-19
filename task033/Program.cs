
/*33. Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
public class Program033 {
    public static void Main (string []args){
        int []arr={1,23,4,5,6,7};
       System.Console.WriteLine(IsThereNumber(arr,5)); 
    }

 private static bool IsThereNumber(int []arr, int checkNumber){
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==checkNumber){
                return true;
            }
        }
        return false;
    }
}