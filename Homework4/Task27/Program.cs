// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int length = NumberLen(number);
int SumD = SumDigits(number, length);
Console.WriteLine("Сумма цифр данного числа: " + SumD);


int NumberLen(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

int SumDigits(int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}