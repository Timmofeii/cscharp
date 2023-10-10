//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

int userNumber = 0;
while (userNumber < 100 || userNumber > 999)
{
    System.Console.WriteLine("Enter your number");// общаемся с человеком
    userNumber = Convert.ToInt32(Console.ReadLine());// запрашиваем число
}
System.Console.WriteLine(userNumber % 10);