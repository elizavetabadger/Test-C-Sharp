/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.WriteLine("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"Сумма натуральных элементов от {m} до {n} составляет {SumNumber(m, n)}");

int SumNumber(int m, int n)
{
    if(m == n)
        return n;
    return n + SumNumber(m, n - 1);
}
