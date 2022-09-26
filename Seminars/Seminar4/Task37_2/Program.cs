int[] CreateArray()
{
    int[] array = new int [new Random().Next(10,12)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 11);
        index ++;
    }
}

int[] Multiply(int[] array)
{
    int[] result;
    
    if (array.Length % 2 == 0)
    {
        result = new int [array.Length / 2];
    }
    else
    {
        result = new int [array.Length / 2 + 1];
    }
    for (int i = 0; i < result.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[(array.Length - 1) - i];
        }
    }
    return result;
}


int[] array = CreateArray();
FillArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", Multiply(array)));