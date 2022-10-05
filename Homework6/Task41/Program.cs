// Пользователь вводит с клавиатуры число M, потом вводит M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.Clear();
Console.WriteLine("Введите размер массива: ");
int[] CreateArray(int size) = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] newArray = ParseToArray(input);
//int[] newArray = RandomArray();

PrintArray(newArray);


int[] array = CreateArray(4);

Console.WriteLine($"[{string.Join(",",array)}] -> {Sum(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-50, 100);
    }
    return array;
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