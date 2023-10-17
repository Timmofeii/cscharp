using System.Xml.XPath;

class Program024{
    public static void Main(string[]args){
        System.Console.WriteLine("Enter number");
        int userNumber=Convert.ToInt32(Console.ReadLine());
        int sum=Sum(userNumber);
        System.Console.WriteLine(sum);
    }
    private static int Sum(int userNumber){
        int result=0;
        for (int i = 1; i <= userNumber; i++)       {
           result+=i; 
        }
        return result;
    }
}