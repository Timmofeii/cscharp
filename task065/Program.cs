// 65. Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
using System;

class NumberRangePrinter
{
    public void PrintNumbersInRange(int numM, int numN)
    {
        if (numM > numN) return;
        else
        {
            Console.Write(numM + " ");
            PrintNumbersInRange(numM + 1, numN);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число M: ");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());

        NumberRangePrinter numberRangePrinter = new NumberRangePrinter();
        numberRangePrinter.PrintNumbersInRange(numberM, numberN);

        Console.ReadLine();
    }
}