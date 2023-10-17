class Progrma028
{
    public static void Main(string[] args)
    {
        int number = 3;
        int result=multipleyer(number);
        System.Console.WriteLine(result);
    }
    private static int multipleyer(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}