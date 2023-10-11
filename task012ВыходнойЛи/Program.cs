/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayOfWeek;
const int minDay = 1;
const int maxDay = 7;
bool validInput = false;
Console.WriteLine("Введите номер дня недели:");
while (!validInput)
{
    if (int.TryParse(Console.ReadLine(), out dayOfWeek) && dayOfWeek >= minDay && dayOfWeek <= maxDay)
    {
        validInput = truel
}
    else { System.Console.WriteLine("Неверное число. Пожалуйста, введите число от 1 до 7."); }

}
if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Нет, это не выходной день.");
}
