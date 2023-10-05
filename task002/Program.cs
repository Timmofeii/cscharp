// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
int userNumber=0;
while(userNumber<1||userNumber>7){
System.Console.WriteLine("Enter your number");
userNumber= Convert.ToInt32(Console.ReadLine());
}
if(userNumber==1){
    System.Console.WriteLine("Monday");
}
ша 