using System;

class Program
{
    static void Main()
    {
        // Nhập vào hệ số a, b, c của phương trình bậc 2
        Console.WriteLine("Nhập hệ số a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập hệ số b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập hệ số c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Tính delta
        double delta = b * b - 4 * a * c;

        // Kiểm tra delta để xác định số nghiệm
        if (delta > 0)
        {
            // 2 nghiệm phân biệt
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}", x1, x2);
        }
        else if (delta == 0)
        {
            // Nghiệm kép
            double x = -b / (2 * a);
            Console.WriteLine("Phương trình có nghiệm kép: x = {0}", x);
        }
        else
        {
            // Phương trình vô nghiệm
            Console.WriteLine("Phương trình vô nghiệm.");
        }
    }
}

