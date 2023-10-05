

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет
System.Console.WriteLine("Enter first number");//тут выводим в консоль текст с запросом числа
int firstNumber = (ConsConvert.ToInt32ole.ReadLine());// тут его считываем/запрашиваем у пользователья
System.Console.WriteLine("Enter second number");// сново выводим в консоль запрос
int secondNUmber= Convert.ToInt32(Console.ReadLine());// запрашиваем второе число
if(firstNumber*firstNumber==secondNUmber){// условие на проверку мы умножаем первое число на него же, а после знаком == 
//проверяем является он значением второго, если да то проходм в скобки и выполняем команду
    System.Console.WriteLine("Да, является квадратом первое второго");
}else{// во всех кругих случаях выполняем этот блок кода
    System.Console.WriteLine("Нет)");
}