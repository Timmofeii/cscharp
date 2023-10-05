  int a, b, c;

           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 8;
           c = 7;
           static int FindMax(int a, int b, int c)
    {
     if(a>b&&a>c){
     return a;
     }else if (b>a&&b>c){
       return b;
       
     }else{
       return c;
     }
    }
         int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");