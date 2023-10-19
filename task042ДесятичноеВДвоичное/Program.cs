/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
using System;
using System.Text;
public class Program042
{
    public static void Main(string[] args)
    {
        int decimenalNumber = 18;
      string binryString = DecimalToBinary(decimenalNumber);
      Random random= new Random();
      int NP= random.Next(1,10);
      System.Console.WriteLine(NP);
    
    System.Console.Write(binryString);
      
    }
    private static string  DecimalToBinary(int number){
        if(number==0){
            return"0";
        }

        StringBuilder binary= new StringBuilder();
        
   

   while(number>0)
    {
     int remainder=number%2; 
     binary.Insert(0,remainder);//вставляем каждый новый элемент в начало списка, так не нужно будет переставлять последний элемент на первый и тд...
      number/=2;

        
    }

    return binary.ToString();}
    
}