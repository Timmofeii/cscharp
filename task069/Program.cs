// 69. Напишите программу, которая на вход принимает
//  два числа A и B, и возводит число А в целую степень B
//   с помощью рекурсии.

using System;

class PowerCalculator
{
    public int CalculatePower(int numA, int numB)
    {
        if (numB == 1) return numA;
        else return numA * CalculatePower(numA, numB - 1);
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число A: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int numberB = Convert.ToInt32(Console.ReadLine());

        PowerCalculator powerCalculator = new PowerCalculator();
        int result = powerCalculator.CalculatePower(numberA, numberB);
        Console.WriteLine(result);

        Console.ReadLine();
    }
}