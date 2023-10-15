/*Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


N = 3 
/*
1
8
27

N = 5
1
8
27
64
125
*/
class Program021{
   
           static void DisplayCubesUpToN(int N)//Метод для вывода числа от 1 до N в кубе
    {
      // Введите свое решение ниже
       for(int i=1;i<=N;i++) {
    double cube = Math.Pow( i, 3);
         Console.WriteLine(cube);
       }
   }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N=3;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           
        }

        
        DisplayCubesUpToN(N);
    }
}
    
