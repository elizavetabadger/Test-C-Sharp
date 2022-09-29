// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = CreateArray();
PrintArray(array);
Reverse(array);
PrintArray(array);

int[] CreateArray()
{
    int[] arr = new int[9];
    Random rand = new Random();
    for (int i = 0; i < 9; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
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

void Reverse(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = temp;
    }
}