Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine($"число {b} квадрат числа {a}");
}
else if (b * b == a)
{
    Console.WriteLine($"число {a} квадрат числа {b}" );
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга" );
}