//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Console.Clear();
Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] newArray = ParseToArray(input);
//int[] newArray = RandomArray();

PrintArray(newArray);

int[] RandomArray()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
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

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
}