// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class NumberReversePrinter
{
    public void PrintNumbersReverse(int number, int current = 1)
    {
        if (current > number) return;
        else
        {
            Console.Write(number + " ");
            PrintNumbersReverse(number - 1, current);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число N: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        NumberReversePrinter numberReversePrinter = new NumberReversePrinter();
        numberReversePrinter.PrintNumbersReverse(userNumber);

        Console.ReadLine();
    }
}