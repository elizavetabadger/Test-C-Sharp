// Напишите метод, который объединяет 2 массива в 1.
Console.Clear();
int[] array1 = {5, 18, 123, 6, 2};
int[] array2 = CreateArray();
PrintArray(array1);
PrintArray(array2);

int[] Sum = Unity(array1, array2);
PrintArray(Sum);

int[] CreateArray()
{
    int[] arr = new int[6];
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
}

int[] Unity(int[] array1, int[] array2)
{
    
        int[] arraySum = new int[array1.Length + array2.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            arraySum[i] = array1[i];
        }

        for (int i = array1.Length; i < arraySum.Length; i++)
        {
            arraySum[i] = array2[i - array1.Length];
        }
        return arraySum;
    
    
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)            
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}