/*Напишите программу, которая печатает последовательность чисел, где каждое следующее равно сумме двух предыдущих. 
На вход принимает 3 числа: n1, n2 и N, где n1 n2 - первые числа последовательности, N – длина последовательности	
3 и 4, N = 5 -> 3 4 7 11 18	
6 и 10, N = 4 -> 6 10 16 26 */

Console.Clear();

int[] RowLikeFibo(int digit, int firstNum, int secondNum)
{
    int[] array = new int[digit];
    array[0] = firstNum;
    array[1] = secondNum;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i -2];
    }
    return array;
}

Console.Write("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine()!);

Console.Write("Введите длину последовательности: ");
int numThree = int.Parse(Console.ReadLine()!);

int[] result = RowLikeFibo(numThree, numOne, numTwo);
Console.Write(string.Join(", " , result));
