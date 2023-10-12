﻿/*Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
 и возвращает расстояние между ними в 3D пространстве.*/
class Program023
{
    static void Main()
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
         
            double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
        }
    }
    private static double Length(int[] pointA, int[] pointB)
    {
        // Введите свое решение ниже
      

        int userBy = Convert.ToInt32(Console.ReadLine());
        double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
        double squereY = Math.Pow(userBy - userAy, 2);
        double rootXY = Math.Sqrt(squareX + squereY); //Math.Sqrt находит  корень квадратный
        System.Console.WriteLine(Math.Round(rootXY, 2));// маз раунд округление 
                                                        //AB= Корень числа (x2-x1)2+(y2-y1)2+(z2-z1)2
    }
}