//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
Console.Clear();
int[] array = new int[] {-4,-8,8,2};
int lenght = array.Length;
for ( int i = 0; i<=array.Length-1; i++)
{
    array[i] = -array[i];
}

PrintArray(array);


void PrintArray (int[] array)
{
    int lenght = array.Length;
    for (int i=0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}