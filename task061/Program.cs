//61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

using System;

class PascalTriangle
{
    public void PrintPascalTriangle()
    {
        Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s);

        for (int i = 0; i < n; i++)
        {
            for (int c = 0; c <= (n - i); c++)
            {
                Console.Write(" ");
            }
            for (int c = 0; c <= i; c++)
            {
                Console.Write(" ");
                Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private float Factorial(int n)
    {
        float x = 1;
        for (float i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;
    }
}

class Program
{
    static void Main()
    {
        PascalTriangle triangle = new PascalTriangle();
        triangle.PrintPascalTriangle();
        Console.ReadLine();
    }
}