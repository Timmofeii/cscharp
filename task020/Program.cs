/*Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.WriteLine("Введите координаты точки a X,Y ");
int userAx =  Convert.ToInt32(Console.ReadLine());

int userAy =  Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B Х,Y");
int userBx =  Convert.ToInt32(Console.ReadLine());

int userBy =  Convert.ToInt32(Console.ReadLine());
double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squereY= Math.Pow(userBy- userAy,2);
double rootXY =Math.Sqrt(squareX+squereY); //Math.Sqrt находит  корень квадратный
System.Console.WriteLine(Math.Round(rootXY,2));// маз раунд округление 

