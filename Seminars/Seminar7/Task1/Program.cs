//Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
Console.Clear();
 
Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine()!);
 
Console.WriteLine(DecToBin(decimalNumber));
 
 
string DecToBin(int decNumber, string binNumber = "")
{
    if (decNumber / 2 > 0)
    {
        binNumber += (decNumber % 2).ToString();
        return DecToBin(decNumber / 2, binNumber);
    }
    else
    {
        binNumber += decNumber.ToString();
        char[] charArray = binNumber.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
