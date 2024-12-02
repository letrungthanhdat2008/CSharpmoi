using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\nNhap n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"So Fibonacci thu {n} la: {Fibonacci(n)}");
        Console.ReadKey();
    }
}