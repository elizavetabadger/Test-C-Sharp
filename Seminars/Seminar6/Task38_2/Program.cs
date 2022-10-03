Console.Clear();
 
double[] array = CreateArray(4);
 
 
// int countOfEven = CountEven(array);
// int sumOfOddIndex1 = OddIndexSum1(array);
// int sumOfOddIndex2 = OddIndexSum2(array);
 
 Console.WriteLine(string.Join(" ", array));
// Console.WriteLine(sumOfOddIndex1);
// Console.WriteLine(sumOfOddIndex2);
 
// double max = FindMax(array);
// double min = FindMin(array);
 
double max = array.Max();
double min = array.Min();
 
Console.WriteLine(Math.Round(max - min, 2));
 
 
double[] CreateArray(int length)
{
    double[] array = new double[length];
 
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(randGenerator.NextDouble() * 10, 2) ;
    }
 
    return array;
}
 
int CountEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            counter++;
    }
    return counter;
}
 
int OddIndexSum1(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    return sum;
}
int OddIndexSum2(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}
 
double FindMax(double[] array)
{
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}
 
double FindMin(double[] array)
{
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}
