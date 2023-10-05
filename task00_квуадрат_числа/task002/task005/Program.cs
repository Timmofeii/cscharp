// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
System.Console.WriteLine("Enter yout number");// общаемся с человеком
int userNumber =Convert.ToInt32(Console.ReadLine());// запрашиваем число
for(int i= 0-userNumber;i<= userNumber;i++){// шагаем в цикле до нашего числа 
  System.Console.Write(i+" ");// выводим в консоль значение i(0, 1, 2..numberUser)
   // if(i%2==0){//выводим все парные 
      //   System.Console.Write(i+" ");
    //}
}