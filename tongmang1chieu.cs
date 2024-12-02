using System;

class tongmang1chieu
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach(int num in arr)
        {
            sum += num;
        }
        Console.WriteLine("\nTong mang la:" + sum);
    }
}
