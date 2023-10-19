/*35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
public class Program035{
    public static void Main(string[]args){
        int []arr={-100,1,2,3,5,6,10,-199};
int count=ValueInTheSegment(arr);
System.Console.WriteLine(count);

    }
     static int ValueInTheSegment(int []arr){
        int count =0;
        for (int i = 0; i < arr.Length; i++)
        {if(arr[i]>9&&arr[i]<100){
            count++;
        }
            
        }
        return count;
    }
}