/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
class Program
{
  static void Main()
  {
    int userNumber = GetValidNumber();
    int thirdDigit = GetThirdDigit(userNumber);

    if (thirdDigit != -1)
    {
      Console.WriteLine(thirdDigit);
    }
    else
    {
      Console.WriteLine("Третьей цифры нет");
    }
  }
  static int GetValidNumber()
  {
    bool validInput = false;
    int number = 0;
    Console.WriteLine("Введите ваше число:");
    while (!validInput)
    {
      if (int.TryParse(Console.ReadLine(), out number))
      {

        validInput = true;
      }
      else
      {
        System.Console.WriteLine("Неверный символ. Пожалуйста, введите число.");
      }
    }
    return number;
  }
  static int GetThirdDigit(int number)
  {
    string numberString = number.ToString();
    const int ThirdDigitIndex = 2;
    if (numberString.Length >= 3)
    {
      return int.Parse(numberString[2].ToString());
    }
    return -1;//означает что третьей цифры нет.
  }

}