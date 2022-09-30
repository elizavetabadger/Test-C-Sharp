// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
double[] array = CreateArray(4);

Console.WriteLine($"[{string.Join(" ",array)}] -> {Math.Round((numMax(array) - numMin(array)), 2)}");

double[] CreateArray(int size)
{
    double[] array = new double[size];
        Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 2);
    }
    return array;
}

double numMin(double[] array)
{
    double min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;
}

double numMax(double[] array)
{
    double max = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    return max;
}