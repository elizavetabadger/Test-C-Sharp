/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.WriteLine("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;

if(n < 1)
{
    Console.WriteLine ("Введено неверное число!");
}
Console.WriteLine ($"{NaturNamber(n, m)}");

int NaturNamber( int n, int m)
{
    if(n == m)
        return n;
    else
        Console.Write($"{NaturNamber(n, m +1)}, ");
        return m;
}