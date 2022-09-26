// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
Console.Clear();

Console.WriteLine(CheckNum(CreateArray ()));

int[] CreateArray ()
{
    int[] array = new int[123];
    Random rand = new Random();
    for (int i=0; i<=122 ; i++)
    {
        array[i] = rand.Next(0,201);
    }
    return array;
}

int CheckNum (int[] array)
{
    int count = 0;
    for (int i = 0; i<=array.Length-1; i++)
    {
        if ((10 <=array[i]) && (array[i]<= 99))
        {
             count++;
        }
    }
    return count;
}
