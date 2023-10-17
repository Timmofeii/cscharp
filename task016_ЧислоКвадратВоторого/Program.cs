/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/
class Program016
{
    static void Main()
    {
        int firstNumber = 25;
        int secondNumber = 5;
        Console.WriteLine(IsOneNumberSquerOfAnother(firstNumber, secondNumber) ? "да" : "нет");// от возвращаюмего значения выведет в консоль заданый ответ 
    }
    static bool IsOneNumberSquerOfAnother(int firstNumber, int secondNumber)
    {
        return firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber;// если одно из условий истина - вернет true иначе false

    }
}