/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
using System;
class Program025
{

    public static void Main(string[] args)
    {
        int baseNumber = 3;
        int exponent = 5;
        System.Console.WriteLine(Power(baseNumber, exponent));
        System.Console.WriteLine(Power(1, 0));
        // System.Console.WriteLine(Power(1, -1));
        System.Console.WriteLine(Power(-2, 4));
    }
    static int Power(int baseNumber, int exponent)
    {
        if (exponent < 0)
        {//проверка на отрицательно значение, если методу придёт значение с отрицательным значением, вызовем exception
            throw new
            ArgumentException("Exponent cannot be negative ");
        }
        if (exponent == 0 || baseNumber == 0)
        { // если baseNumber/ exponent ==0 вернем 1
            return 1;
        }
        if (baseNumber < 0)
        {
            throw new
            ArgumentException("Base number cannot be negative");
        }
        int value = 1;
        for (int i = 0; i < exponent; i++)
        {
            value *= baseNumber;

        }
        return baseNumber * Power(baseNumber, exponent - 1);// рекурсивный метод вызывающий сам себя пока значение exponent не будет равно 0  и тогда уже вернет нужное значение
                                                            // return value;// для проверки цикла, нужно закомментировать строку выше и эту строку наоборот
    }
}