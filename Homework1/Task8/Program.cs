//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.WriteLine("Введите любое число от 1: ");
int number = int.Parse(Console.ReadLine());
int i = 2;

while (number > i) 
    {
     Console.WriteLine ($"{i}");
      i+=2;
      }    