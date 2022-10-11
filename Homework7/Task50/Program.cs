// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
 
int[,] array = new int[6, 6];

FillArray(array);
PrintArray(array);

Console.Write("Введите индекс строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int column = int.Parse(Console.ReadLine()!);


if (ElementArray(array, row, column))
{
    Console.WriteLine($"Элемент с такими индексами -> {(array[row, column])}");
}
else
{
    Console.WriteLine("Элемента с таким индексом не существует");
}

bool ElementArray(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) &&
        column < array.GetLength(1) &&
        row >= 0 && column >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}