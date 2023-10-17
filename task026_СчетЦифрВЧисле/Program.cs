class Program
{// должен считать цифрЫ
    public static void Main(string[] args)
    {
        int number = 123456; 
        int countDg=CountDg(number);
      System.Console.WriteLine(countDg); 
    }
    private static int CountDg(int number)
    {
        string stringNumber= number.ToString();
        
       
      
 
        return  stringNumber.Length;
    }
}