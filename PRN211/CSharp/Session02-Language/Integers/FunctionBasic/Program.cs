namespace FunctionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintList1To100();
            //PrintEvenFrom1To100();
            //SumListFrom1To100();
            //int sum = SumEvenFrom1To10();
            //Console.WriteLine(sum);
            //Tính tổng chẵn từ 1 đến 10
            //2 + 4+...+ 10
            //Actual Value: hàm chạy đi , đoán xem
            //Console.WriteLine($"Sum even from 1...10: {SumEvenFrom1To10()}");
        }

        //CHALLANGE 1(C#1): Viết 1 hàm in ra các số từ 1 - 100
        static void PrintList1To100()
        {
            Console.WriteLine("The list of number from 1...100");
            //có việc gì đó lặp lại ta xài: FOR, DO-WHILE , WHILE i chang JAVA
            //Java và C# nếu trong for, if, else chỉ có 1 lệnh thì 
            //trong lệnh k cần dấu {}

            for (var i = 1; i <= 100; i++) 
                Console.Write($"{i}" + " ");

            Console.WriteLine();

        }

        //C#2: Viết hàm in ra các số chẵn 1 ... 100
        static void PrintEvenFrom1To100()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                    Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
        //Hàm cần phải trả về 5050, cho dù chua viết code xong, -> 5050 được gọi là expected value
        //Thực tế khi chạy là mấy: có thể là 6000, 7000... tuỳ vào tài năng viết code; nhưng cũng có thể là 5050 thật
        //Con số trả về của hàm khi run gọi là Actual Value
        //Nếu Excepted Value = Actual Value => hàm ngon
        //                   !=              =>bug
        //Kĩ thuật kiểm thử code của dân Dev để đảm bảo hàm chạy đúng với các case/tình huống data => gọi là Unit Test

        //C#3: viết hàm tính tổng các số từ 1 cho đến 100 và in ra
        //C#4: viết hàm tỉnh tổng các số chẵn từ 1..10 và trả về
        static void SumListFrom1To100()
        {
            var sum = 0;
            for (int i = 0; i <= 100; i++)
                sum += i;

            Console.WriteLine($"SUM(1 to 100): {sum}");
            Console.WriteLine();
        }

        static int SumEvenFrom1To10()
        {
            var sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
//hàm hay là method là một đơn vị code 1 nhóm code/dòng lệnh được đặt chung 1 cái tên và làm 1 việc gì đó: có thể là
//                              in ra một kết quả gì đó
                                //trả về 1 kết quả gì đó, return xxxx;

//Hàm truyền thống xưa nay chỉ trả về 1 giá trị qua lệnh/ngõ return xxx;
//C# hỗ trợ thêm hàm tả về nhiều giá trị nhưng ...


//vd: hàm tính căn bậc 2 : gồm 1 đống câu lệnh làm 1 việc gì đó, đặt tên là là Sqrt()
//JAVA: sqrt()-> trả về chứ k in ra căn bậc 2 của x
//C#: Sqrt()
