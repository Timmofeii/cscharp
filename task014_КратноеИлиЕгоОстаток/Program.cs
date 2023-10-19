// Условия задачи по памяти...Считать число и проверить ли
// кратное оно к примеру 2, если кратно, то вывести что кратное, если нет то вывести остаток 

class Program
{
    static void Main()
    {

        System.Console.WriteLine(multipleAndRemainder());
    }
    static string multipleAndRemainder()
    {
        System.Console.WriteLine("Enter your number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());// разберусь как делать зависимости в С# и буду методы вызывать которые написал ранее, пока так....
        int multiple = userNumber % 2;
        if (multiple == 0)
        {
            return "Число кратное";
        }
        else
        {
            return "" + multiple;
        }


    }
}