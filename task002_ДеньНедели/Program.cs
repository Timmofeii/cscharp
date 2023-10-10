﻿/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
using System.Security.Cryptography;
int userNumber = 0;
while (userNumber < 1 || userNumber > 7)
{
    System.Console.WriteLine("Enter your number");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
switch (userNumber)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;

    case 3:
        System.Console.WriteLine("Wednesday");
        break;
    case 4:
        System.Console.WriteLine("Thursday");
        break;
    case 5:
        System.Console.WriteLine("Friday");
        break;
    case 6:
        System.Console.WriteLine("Saturday");
        break;
    case 7:
        System.Console.WriteLine("Sunday");
        break;
}
