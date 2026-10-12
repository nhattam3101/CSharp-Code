using System;

class Program
{
    static void Main(string[] args)
    {
        //c# nó phân biệt chữ hoa chữ thường
        int x = 10;
        int X = 20;
        //2 cái này là khác nhau
        //case-sensive
        //tên biến hay tên của class thường gọi nó là mọt cái định danh
        //định danh bằng _ hoặc các chữ cái, sau đó là các chữ cái hoặc _ hoặc số
        int x1 = 30;
        //int 1x = 40; => sai 
        
        //Các quy tắc đăặt tên cho biến:
        //1. Thường dùng quy tắc lạc đà (Camel Notation) cho tên biến.
        string myString = "Nguyen Van a";
        String hoVaten = "Hoang Nhat Tam";
        
        //2. Dùng cú pháp Pascal để đặt tên hàm , hằng số và thuộc tính
        const double PI = 3.14;
        const string SINHVIENMAU = "Hoang Nhat Tam";

        void HelloWorld()
        {
            Console.WriteLine("Hello chúng mày!!");
        }

        HelloWorld();
        
        //Kiểu dữ liệu của c#
        //1. Kiểu dữ liệu cơ bản
        //2. Kiểu dữ liệu tham chiếu


    }
}