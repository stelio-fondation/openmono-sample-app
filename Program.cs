Console.WriteLine("Hello, World!");
Console.WriteLine(Fibonacci(10));

int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
