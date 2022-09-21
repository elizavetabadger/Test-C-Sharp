Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if ((a % 7 == 0) && (a % 23 == 0))
    Console.WriteLine($"число {a} кратно 7 и 23");
else
    Console.WriteLine($"число {a} НЕ кратно 7 и 23");