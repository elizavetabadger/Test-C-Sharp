// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear(); 
Console.WriteLine("Введите значение b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine()!);
intersectionPoint(b1, k1, b2, k2);

double intersectionPoint(double B1, double K1, double B2, double K2)
{
    double x = 0;
    double y = 0;
    if ((K1 == K2) && (B1 == B2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (K1 == K2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (B2 - B1)/(K1 - K2);
        y = K1 * x + B1;
        Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
    return 0;
}
