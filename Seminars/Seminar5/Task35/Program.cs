// Напишите метод, который суммирует 2 массива. Каждый элемент одного массива должен суммироваться с соответствующим элементом из второго массива. Если длины массивов не равны, то должно появляться сообщение об ошибке
//Console.Clear();

int[] array1 = {2,3,6,8,2,0};
int[] array2 = CreateArray();
PrintArray(array1);
PrintArray(array2);

if (array1.Length != array2.Length)
   Console.WriteLine("Ошибка, массивы не равны!");
else
   {
        int[] Sum = SumArray(array1, array2);
        PrintArray(Sum);
   }


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
int[] SumArray(int[] array1, int[] array2)
{
    
        int[] arraySum = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            arraySum[i] = array1[i] + array2 [i];
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
