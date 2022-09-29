﻿int[] ParseToArray(string str)

{
    string[] stringArray = str.Split(" "); 
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

int[] SumOfArray(int[] firstArray, int[] secondArray)
{
    int[] result = new int [firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        result[i] = firstArray[i] + secondArray[i];
    }

    return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] fArray = ParseToArray(firstArray);
int[] sArray = ParseToArray(secondArray);

if(fArray.Length != sArray.Length)
{
    Console.Write("Массивы неравноразмерны!!!!11!");
}
else
{
    int[] res = SumOfArray(fArray, sArray);
    Console.Write(String.Join(", ", res));
}
