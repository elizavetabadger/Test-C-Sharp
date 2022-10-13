// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] matrix = CreateMatrix(3, 3, 0, 9);
PrintMatrix(matrix);
 
int minRowSum = int.MaxValue;
int minRowSumIndex = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = GetRowSum(matrix, i);
    if (rowSum < minRowSum)
        minRowSumIndex = i;
}
Console.WriteLine(minRowSumIndex);
PrintMatrix(matrix);
 
 
 
 
void SortMatrixRow(int[,] matrix, int rowIndex)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, i] < matrix[rowIndex, j])
            {
                int buff = matrix[rowIndex, i];
                matrix[rowIndex, i] = matrix[rowIndex, j];
                matrix[rowIndex, j] = buff;
            }
        }
    }
}
 
int GetRowSum(int[,] matrix, int rowIndex)
{
    return 0;
}
 
int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random generator = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = generator.Next(min, max + 1);
        }
    }
    return result;
}
 
void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
