﻿Console.Clear();
int number = new Random ().Next(100,1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int lastDigit = number % 10;

Console.WriteLine($"{firstDigit}{lastDigit}");