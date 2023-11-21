// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;

class NumberRangeSum
{
    public int SumNumbersInRange(int numM, int numN)
    {
        if (numM <= numN)
        {
            return numM + SumNumbersInRange(numM + 1, numN);
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
        Console.WriteLine("Введите число M: ");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());

        NumberRangeSum numberRangeSum = new NumberRangeSum();
        int result = numberRangeSum.SumNumbersInRange(numberM, numberN);
        Console.WriteLine(result);

        Console.ReadLine();
    }
}