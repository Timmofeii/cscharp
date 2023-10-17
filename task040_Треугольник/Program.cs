/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. */
public class Program040
{
    public static void Main(string[] args)
    {

        int[] sides = GetTringleSides();

        bool isTringle = IsTriangle(sides);
        System.Console.WriteLine("Is it a tringle? "+isTringle);

    }
    private static int[] GetTringleSides()
    {
        int[] sides = new int[3];
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Enter number " + (i + 1)+":");
            sides[i] = Convert.ToInt32(Console.ReadLine());

        }
        return sides;
    }
    private static bool IsTriangle(int[] sides)
    {
        int a = sides[0];
        int b = sides[1];
        int c = sides[2];

        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
