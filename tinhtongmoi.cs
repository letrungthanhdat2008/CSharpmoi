using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtongmoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("\nChuong trinh tinh tong!");
            Console.Write("\nNhap mot so nguyen:");
            int n = int.Parse(Console.ReadLine());  

            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong tu 1 den" + n + "la:" + sum);
        }
    }
}
