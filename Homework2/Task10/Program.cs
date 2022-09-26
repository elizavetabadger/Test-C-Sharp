// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int amount = number.ToString().Length;
int secondDigit = number / 10 % 10;

if (amount < 3 || amount > 3)
{
    Console.WriteLine($"Ошибка! Введено неверное число ");
}
else
{
    Console.WriteLine($" -> {secondDigit}");
}