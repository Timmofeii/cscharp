// 67. Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.

using System;

class DigitSum
{
    public int GetSumOfDigits(int num)
    {
        if (num % 10 > 0)
        {
            return num % 10 + GetSumOfDigits(num / 10);
        }
        else
        {
            return 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число N: ");
        int number = Convert.ToInt32(Console.ReadLine());

        DigitSum digitSum = new DigitSum();
        int result = digitSum.GetSumOfDigits(number);
        Console.WriteLine(result);

        Console.ReadLine();
    }
}