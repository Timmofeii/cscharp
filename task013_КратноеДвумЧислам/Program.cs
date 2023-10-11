/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> 
*/
class Program
{
    static void Main()
    {
       System.Console.WriteLine(multipleOfTwo()); 
    }
    static string multipleOfTwo(){
        System.Console.WriteLine("Enter your");
        int firstNUmber = Convert.ToInt32(Console.ReadLine());
        if(firstNUmber%7==0&&firstNUmber%23==0){
          return "да";
        }
        else{
           return "нет";
        }
         

    }
}
