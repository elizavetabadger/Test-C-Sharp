// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
 
int numberCount = int.Parse(Console.ReadLine()!);
int counter = 0;
 
for (int i = 0; i < numberCount; i++)
{
    int currentNumber = int.Parse(Console.ReadLine()!);
    if (currentNumber > 0)
    {
        counter++;
    }
}
 
Console.WriteLine(counter);