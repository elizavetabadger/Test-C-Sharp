// Напишите программу, которая принимает на вход 2 числа, количество строк и количество столбцов, создаёт матрицу данного размера и заполняет нулями или единицами в случайном порядке и выводит в консоль.

void PrintArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i, j]} ");
         }
         Console.WriteLine();
     }
 }

 void FillArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i, j] = new Random().Next(0, 2);
         }
     }
 }

 Console.Write("Введите кол-во строк: ");
 int a = int.Parse(Console.ReadLine()!);
 Console.Write("Введите кол-во столбцов: ");
 int b = int.Parse(Console.ReadLine()!);

 int[,] matrix = new int[a, b];

  FillArray(matrix);
 Console.WriteLine();
 PrintArray(matrix);