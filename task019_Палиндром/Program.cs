
/*напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.


14212 -> False
12821 -> True
234322 -> Число не пятизначно False*/
using System.Security.AccessControl;

class Program019
{
  static void Main()
  {
    int number = 234322;
    bool isPalindrome = IsPalindrome(number);// первое решение к которому я сам пришел и как захотел решать 
    bool isPalindrome2 = IsPalindromeSecond(number);// решение которое сам написл после просмотра код коллег
    Console.WriteLine(isPalindrome);
    Console.WriteLine(isPalindrome);
  }
  static bool IsPalindrome(int number)
  {
    string numberString = number.ToString();
    // string reversNumber;

    int length = numberString.Length;
    const int rightLength = 5;
    if (length != rightLength)
    {
      System.Console.WriteLine("Число не пятизначное");
      return false;
    }
    for (int i = 0; i < length / 2; i++)
    {
      if (numberString[i] != numberString[length - 1 - i])// сравниваем первые и  последние значение, если где-то несоотвествие, возвращаем false
      {
        return false;
      }

    }
    return true;


  }
  static bool IsPalindromeSecond(int number)
  {
    if (number < 10000 || number > 99999)
    {
      System.Console.WriteLine("Число не пятизначное");
      return false;

    }
    
    int reversNumber = 0;
    int originNumber=number;

    for (int i = 0; i < 5; i++)
    {
     
      int lastDigin = number  % 10;

      reversNumber = reversNumber * 10 + lastDigin;
      number/=10;


    }
 
    
      return reversNumber==originNumber;
    


  }
}