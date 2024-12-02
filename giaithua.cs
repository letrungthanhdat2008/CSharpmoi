using System;

class Program
{
    static long GiaiThua(int n)
    {
        long ketQua = 1;
        for(int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }
        return ketQua;
    }
    static void Main()
    {
        Console.Write("\nNhap n:");
        int n = int.Parse(Console.ReadLine());
        if(n < 0)
        {
            Console.WriteLine("Giai thua khong xac dinh cho so am");
        }
        else
        {
            long ketQua = GiaiThua(n);
            Console.WriteLine("Giai thua cua {0} la: {1}", n,ketQua);
        }
        Console.ReadKey();
    }
}
