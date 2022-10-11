//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("---");

FillArray(matrix2);
PrintArray(matrix2);

if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Нельзя перемножать ");
    return;
}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("---");

PrintArray(resultMatrix);

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
