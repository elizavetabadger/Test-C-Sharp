//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Clear();

Console.WriteLine("Введите порядковый номер дня недели, а я подскажу, выходной ли это день. ");
int number = int.Parse(Console.ReadLine()!);

if ((number < 1) | (number > 7)) 
{
    Console.WriteLine ("The Universe doesn't have such a day of the week. Try again!");
}
else if (number < 6) 
{
    Console.WriteLine ("Eh, it's a weekday...");
}
else
{
    Console.WriteLine ("Yes, it's a weekday!");
}