﻿//Console.Clear();
Console.Write("Введите номер координатной четверти: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1) 
{
    Console.WriteLine("X > 0 & Y > 0");
}

if (number == 2) 
{
    Console.WriteLine("X < 0 & Y > 0");
}

if (number == 3) 
{
    Console.WriteLine("X < 0 & Y < 0");
}

if (number == 4) 
{
    Console.WriteLine("X > 0 & Y < 0");
}