Console.Clear();

Console.Write("Введите положительное число N: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int i = number*(-1);

while (i <= number) 
    {
     Console.WriteLine (i);
      i+=1;
      }