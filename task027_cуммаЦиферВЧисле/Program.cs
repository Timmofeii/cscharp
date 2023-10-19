/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
class Program027
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your number: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(SummNumbers(userNumber));

    }
    private static int SummNumbers(int userNumber)
    {
        int sign = Math.Sign(userNumber);//метод для  запоминания знaчения +-
        int summNumbers = 0;
        userNumber= Math.Abs(userNumber);// вовзодим в абсолютное значение 
        for (int number = userNumber; number > 0; number /= 10)// шагаем по цифре, каждый шаг деля на 10
        {
            int lastDigin=number % 10;// берем каждое последнее значение
            summNumbers += lastDigin*sign;//   возвращаем последнему элементу свое знак -,+ и добавляем к сумме 

        }

        return summNumbers;
    }
}