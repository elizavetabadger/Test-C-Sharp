Console.Clear();
double SlowFibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return SlowFibonacci(n - 1) + SlowFibonacci(n - 2);
}
double FastFibonacci(int n, int sum = 0)
{
    if (n == 0) 
        return sum;
    else
        return FastFibonacci(n - 1, sum + n);
}

Console.Write(FastFibonacci(5));
