Console.Clear();

Console.Write("Введите число N: ");
int x = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= x)
//{
//    int result = (int)Math.Pow(count, 2);
//    Console.Write(result + ",");
//    count++;
//}
{
    Console.Write($"{Math.Pow(count, 2)}");
    if (count != x)
    Console.Write(", ");
    count++;
}