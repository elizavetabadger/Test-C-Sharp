//Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"{b} кратно {a}");
}
else
{
    Console.WriteLine($"остаток от деления {a % b}");
}