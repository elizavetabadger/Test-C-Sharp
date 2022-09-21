Console.Clear();

Console.WriteLine("Введите трёхзначное число N: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int result = number%10;
Console.WriteLine(result);