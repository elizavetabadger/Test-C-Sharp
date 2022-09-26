// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Clear();

Console.Write("Введите координату X0 для А ");
double X0 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y0 для А ");
double Y0 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z0 для А ");
double Z0 = double.Parse(Console.ReadLine()!);

Console.Write("Введите координату X1 для B ");
double X1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y1 для B ");
double Y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z1 для B ");
double Z1 = double.Parse(Console.ReadLine()!);


double result = Math.Sqrt(Math.Pow(X1 - X0, 2) + Math.Pow(Y1 - Y0, 2) + Math.Pow(Z1 - Z0, 2));
Console.WriteLine (result.ToString("#.00"));