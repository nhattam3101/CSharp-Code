namespace Variable;

class Program
{
    static void Main(string[] args)
    {
        int edge;
        int width, length;
        int radius;
        
        //1. Tính diện tích hình vuông
        Console.Write("Nhập cạnh: ");
        edge = int.Parse(Console.ReadLine());
        Console.WriteLine("Area circle: " + CalculatorArea.CalculateSquareArea(edge));
        
        //2. Tính diện tích hình cn
        Console.Write("Nhập chiều rộng: ");
        width = int.Parse(Console.ReadLine());
        Console.Write("Nhập chiều dài: ");
        length = int.Parse(Console.ReadLine());

        Console.WriteLine("Area rectangle: " + 
                          CalculatorArea.CalculateRectangleArea(width, length));
        
        //3. Tính diện tích hình tròn
        Console.Write("Nhập bán kính: ");
        radius = int.Parse(Console.ReadLine());
        Console.WriteLine("Area circle: " + CalculatorArea.CalculateCircleArea(radius));











        //int studentAge = 20;//local variable
        //const double Pi = 3.14;
        //trong C# không có biến kiểu gọi là global giống các ngôn ngữ khác
        //mà nó gòi là Field
        //static void HelloWorld()// tên của method theo kiểu PascalCase
        //{// còn tên của parameter là camelCase
        //Console.WriteLine(studentAge);   -- sẽ không dùng được local variable 
        //

        /*
            1. Biến lưu chiều rộng hình chữ nhật
            2. Biến lưu bán kính hình tròn
            3. Hằng số lưu PI
            4. Method tính diện tích hình tròn
            5. Parameter nhận chiều dài hình chữ nhật
         */
        //1.
        /*
        int width;
        int radius;
        const double pi = 3.14;

        void CalculateCircleArea(int radius)
        {
            Console.WriteLine("Area: {0}", (pi*radius));
        }

        void AcceptLenghtRectangular(int lenghtRactangular)
        {
            Console.WriteLine(lenghtRactangular);
        }
        */

        //-----------------------------
        /*
        string studentName = "Tam";
        int studentAge = 20;
        double score = 8.5;

        //1. Dùng nối chuỗi "+"
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("Score: " + score);
        Console.WriteLine("My name is " + studentName + ". My age is " + studentAge + ". My score is " + score);
        Console.WriteLine("======================================================================================");
        //2. Dùng placeholder
        Console.WriteLine("Name: {0}, Age: {1}", studentName, studentAge);

        //3. Dùng interpolation
        Console.WriteLine($"Name: {studentName}, Age: {studentAge}");
        */
        /*
        string productName = "Laptop";
        double price = 1500.5;
        int quantity = 2;

        //1. Nối  chuõi
        Console.WriteLine("Product: " + productName + ", Price: " + price + ", Quantity: " + quantity);

        //2. Placeholder
        Console.WriteLine("Product: {0}, Price: {1}, Quantity: {2}", productName, price, quantity);

        //3. Interpolution
        Console.WriteLine($"Product: {productName}, Price: {price}, Quantity: {quantity}");
        */

    }
}