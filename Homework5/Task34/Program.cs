// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = CreateArray(6);

Console.WriteLine($"[{string.Join(",",array)}] -> {evenNumbers(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
        Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(101, 1000);
    }
    return array;
}

int evenNumbers(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        number++;
    }
    return number;
}