﻿/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int random = new Random().Next(100, 1000);
System.Console.WriteLine(randome);
randome = (randome % 100 - randome % 10) / 10;

System.Console.WriteLine(randome);
