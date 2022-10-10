//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Введите m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int column = int.Parse(Console.ReadLine()!);
 
double[,] array = new double[row, column];
FillArray(array);
PrintArray(array);
 
 
 
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i,j] = Math.Round(new Random().NextDouble() * 10, 2);
            }
        }
    }
}
 
 
 void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
