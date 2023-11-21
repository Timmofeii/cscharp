// 63. Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N.

using System;

class NumberPrinter
{
    public void PrintNumbers(int number, int current = 1)
    {
        if (number < current) return;
        else
        {
            Console.Write(current + " ");
            PrintNumbers(number, current + 1);
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

        NumberPrinter numberPrinter = new NumberPrinter();
        numberPrinter.PrintNumbers(number);

        Console.ReadLine();
    }
}