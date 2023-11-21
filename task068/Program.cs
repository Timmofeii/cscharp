// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class AckermannFunction
{
    public int Ackerman(int mNum, int nNum)
    {
        if (mNum == 0)
        {
            return nNum + 1;
        }
        else if (mNum != 0 && nNum == 0)
        {
            return Ackerman(mNum - 1, 1);
        }
        else
        {
            return Ackerman(mNum - 1, Ackerman(mNum, nNum - 1));
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число m: ");
        int mNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n: ");
        int nNumber = Convert.ToInt32(Console.ReadLine());

        AckermannFunction ackermannFunction = new AckermannFunction();
        int result = ackermannFunction.Ackerman(mNumber, nNumber);
        Console.WriteLine(result);

        Console.ReadLine();
    }
}