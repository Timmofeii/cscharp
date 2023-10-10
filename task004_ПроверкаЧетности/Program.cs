/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
static void CheckIfEven(int number)
{
  // Введите свое решение ниже
  if (number % 2 == 0)
  {
    System.Console.WriteLine("Число `" + number + "` чётное");
  }
  else
  {
    System.Console.WriteLine("Число `" + number + "` нечётное");
  }
}
//int number=6;
System.Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckIfEven(number);