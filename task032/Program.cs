//32. Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
public class Program032{
    public static void Main(string []args){
        int []arr={-4,-8,8,2};
         System.Console.WriteLine(string.Join(" ",arr));
        DifferentValue(arr);
        System.Console.WriteLine(string.Join(" ",arr));
    }
    private static int [] DifferentValue(int []arr){
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]=arr[i]*-1;
        }
        return arr;
    }
}