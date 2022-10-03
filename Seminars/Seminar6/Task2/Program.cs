// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. Использовать рекурсию
Console.Clear();

int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{SumDigit(number)}");

int SumDigit(int number, int counter = 1)
{
    if (number > 0)
    {
        number = number / 10;
        counter++;
        number = SumDigit(number, counter);
        return number;
    }
    else
    {
        return counter - 1;
    }
}
