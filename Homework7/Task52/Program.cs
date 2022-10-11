//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = new int[row, column];

FillArray(array);
PrintArray(array);

double[] ArrayAverage = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j,i];
    }
    ArrayAverage[i] = sum / array.GetLength(0);
}

PrintArrayAverage(ArrayAverage);

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

void PrintArrayAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
