//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.


System.Console.WriteLine("Enter yout number");// общаемся с человеком
int userNumber =Convert.ToInt32(Console.ReadLine());// запрашиваем число
System.Console.WriteLine(userNumber%10);