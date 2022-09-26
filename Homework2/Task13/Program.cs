// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите число, а я выведу третью цифру этого числа: ");
int number = (int)Math.Abs(int.Parse(Console.ReadLine()!)); //модуль числа

if (number < 100)
{
    Console.WriteLine($"Ой, к сожалению, третьей цифры у числа нет. Введите другое число. ");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра данного числа -> {number % 10}");
}