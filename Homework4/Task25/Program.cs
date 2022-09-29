//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int DPower = Power(numberA, numberB);
Console.Write("Число А в степени В: " + DPower);

int Power(int a, int b)
{
   int result = 1;
   for (int i = 1; i <= b; i++)
   {
        result = result * a;
   }
   return result;
}
