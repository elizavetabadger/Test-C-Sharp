//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = CreateArray(4);

Console.WriteLine($"[{string.Join(",",array)}] -> {Sum(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
        Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-50, 100);
    }
    return array;
}

int Sum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        count += array[i];
    }
    return count;
}
// в решении приведен подсчет суммы по нечетным позициям - по НЕЧЕТНЫМ ИНДЕКСАМ