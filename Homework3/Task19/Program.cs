// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int digit = number.Length;

if (digit < 5 || digit > 5)
{
    Console.WriteLine($"Ошибка! Введено неверное число. ");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Вау, это число палиндром!");
    }
    else
    {
        Console.WriteLine($"К сожалению, это не палиндром.");
    }
}