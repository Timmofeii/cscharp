using System;
using System.Text;
/* 45. Напишите программу, которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования.*/

class Program
{
    public static void Main(string[] args)
    {
int []arr= {1,2,3,4,5,6,7,8,9,10};
int []copyArraty=CopyArr(arr);
System.Console.WriteLine(string.Join(" ",copyArraty));
    }public static int[] CopyArr(int []array){
        int arrLength= array.Length;
        int []copyArr=new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
          
            copyArr[i]=array[i];
            
        }
return copyArr;    }
}