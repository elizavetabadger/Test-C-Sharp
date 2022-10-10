//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите индекс строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = new int[row, column];

PrintArray(array);
Console.WriteLine();
PrintArray(array);


void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i,j] = generator.Next(0, 10);
            }
        }
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

int[] CalcAverage(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    int sum;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result[i] = sum / array.GetLength(0);
    }
    return result;
}
