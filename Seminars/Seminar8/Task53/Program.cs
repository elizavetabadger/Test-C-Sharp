// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

int[,] matrix = new int[5,5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
RepleceRowArray(matrix);
PrintArray(matrix);

void RepleceRowArray(int[,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0 , j] ;
        array[0 , j] = array[array.GetLength(1) - 1 , j];
        array[array.GetLength(1) - 1 , j] = temp;
    }
}

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