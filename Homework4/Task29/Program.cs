//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Console.Clear();

int[] array =  new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = randGenerator.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + " ");
    }
}