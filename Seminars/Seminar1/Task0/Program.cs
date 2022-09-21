Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int sqr = number * number;
int sqr2 = (int)Math.Pow(number,3);

Console.WriteLine(sqr);
Console.WriteLine(sqr2);