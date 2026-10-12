// các khái niệm ép kiểu
//Ép kiểu tự động 
//ép kiểu tường minh
using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        /*
        short x = 1;
        int y = 2;
        y = x;
        Console.WriteLine(y);
        */

        int z = 10;
        short t = 10;
        t = (short)z;
        Console.WriteLine(t);

        int a = 5;
        int b = 2;
        Console.WriteLine("{0}/{1} = {2}", a, b, a /b);
        Console.WriteLine("{0}/{1} = {2}", a, b, (double)a/b );
    }
}