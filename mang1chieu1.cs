using System;

class mang1chieu1
{
    static void Main(string[] args)
    {
        Console.Write("\nNhap so luong phan tu cua mang:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("\nNhap cac phan tu cua mang:");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nMang vua nhap la:");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
