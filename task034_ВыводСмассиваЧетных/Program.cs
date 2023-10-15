﻿/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
class Program034{
    public static void Main(string []args){
      int [] arr= new int[8];
       FullArrRandomNumbers(arr);
      
     
     System.Console.WriteLine( HowManyEvenInArray(arr));
    } 
    private static void FullArrRandomNumbers(int []arr){
 var rand = new Random();
      
    
     for (int i = 0; i < arr.Length; i++)
     {
        arr[i] = rand.Next(100,1000);
     }
    }
     private static int HowManyEvenInArray(int []arr){
         int count=0;  for (int i = 0; i < arr.Length; i++)
     
        {
            if(arr[i]%2==0){
                count++;
            }
        
        }
     return count;}
    
}