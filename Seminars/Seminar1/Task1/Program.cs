Console.Clear();
Console.Write("Введите квадрат числа: ");
string inputOne = Console.ReadLine();
Console.Write("Введите число: ");
string inputTwo = Console.ReadLine();
int numberOne = int.Parse(inputOne);
int numberTwo = int.Parse(inputTwo);

if (numberOne == numberTwo*numberTwo) {
    Console.WriteLine("True");
} 
else {
    Console.WriteLine("False");
}