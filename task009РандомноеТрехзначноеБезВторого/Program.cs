﻿/*
Написать программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/
int random = new Random().Next(100,1000);
int withoutSecond= (random/100)*100+ (random%10);
System.Console.WriteLine(random);
System.Console.WriteLine(withoutSecond);