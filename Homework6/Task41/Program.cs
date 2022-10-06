// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.WriteLine($"Введите количество цифр: ");
int numCount = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите цифры через ENTER: ");
int[] numArray = new int[numCount];
 
for (int i = 0; i < numArray.Length; i++)
{
    numArray[i] = int.Parse(Console.ReadLine()!);
}
 
Console.WriteLine($"Количество чисел больше 0 = {CountPositiveNumbers(numArray)}");


int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}