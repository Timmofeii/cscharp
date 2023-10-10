﻿/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
int firstNumber, secondNumber;
firstNumber = -3;
secondNumber = -9;
if (firstNumber < secondNumber)
{
    System.Console.WriteLine("Первое число " + firstNumber + " меньше чем второе число " + secondNumber);
}
else if (firstNumber == secondNumber)
{
    System.Console.WriteLine("Введенные числа равны " + firstNumber);
}
else
{
    System.Console.WriteLine("Первое число " + firstNumber + " больше чем второе число " + secondNumber);

}

