﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
class Program029{
public static void Main(string[]args){
int [] userArr=new int[2];// мне для проверки 2-х хватило))
FullAndPrintArr(userArr);


}
private static void FullAndPrintArr(int []arr){
    for (int i = 0; i <arr.Length; i++)
    {System.Console.WriteLine($"Enter [{i}] element arr");
    arr[i]=Convert.ToInt32(Console.ReadLine());
        
        
    }
    
    PrintArr(arr);
}
private static void PrintArr(int []arr){
  /*System.Console.Write("[");  
  System.Console.Write(string.Join(", ",arr));// вывод через метод Join класа string 
  System.Console.Write("]");*/
System.Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{System.Console.Write(arr[i]);
if(i<arr.Length-1){
    System.Console.Write(", ");
}
    
}
System.Console.Write("]");
}

}