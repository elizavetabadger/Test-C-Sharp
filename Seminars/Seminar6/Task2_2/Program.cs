// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. Использовать рекурсию.
Console.Write($"Введите число: ");

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

int CountDigits(int number, int counter = 0)
{

    if (number / 10 == 0) 
    {
        return counter + 1;
    }
    else
    {
        return counter + CountDigits(number / 10) + 1;
    }

}

/*Console.Clear();
int number = int.Parse(Console.ReadLine());

Console.WriteLine(CountNumber(number));


int CountNumber(int num)
{
    if (num / 10 < 1) return 1;
    
    else return 1 + CountNumber(num/10);
}*/
 