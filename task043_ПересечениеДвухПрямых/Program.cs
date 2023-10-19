/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
public class Program043
{
    public static void Main(string[] args)
    {
        int []arrCoordinatePoints=CoordinatePoints();
       // FindingThePointOfIntersectionOfTwoLines();
    }
     private static int[]CoordinatePoints()
     {
        int []arr= new int[4];
        for (int i = 0; i < 4; i++)
        {System.Console.WriteLine("Enter coordinate points: "+(i+1));
        arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        return arr;
     }}