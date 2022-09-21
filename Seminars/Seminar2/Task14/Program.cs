Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine((a % 7 == 0) && (a % 23 == 0));