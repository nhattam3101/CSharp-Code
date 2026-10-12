namespace lesson_01_d;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Xác định chỉ số BMI của mỗi người
        //cân nặng và chiều cao của moi người
        //nhập từ bàn phím
        
        //BMI = cân nặng / chiều cao ^ 2;
        double height = 0;
        double weight = 0;
        
        //cách để muốn in ra chữ dấu:
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("TÍNH BMI !!");
        Console.Write("Nhập cân nặng của bạn: ");
        weight = double.Parse(Console.ReadLine());
        //
        Console.Write("Nhập chiều cao của bạn: ");
        height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("BMI của bạn là: " + bmi);
        Console.WriteLine("Nhập một phím bất kì để thoát: ");
        Console.ReadKey();//đọc 1 phím từ bên ngoài bàn phím thôi

    }
}