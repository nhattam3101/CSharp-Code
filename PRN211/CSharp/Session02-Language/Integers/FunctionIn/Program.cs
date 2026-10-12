namespace FunctionOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoSomethingV2(500);// dự kiến in đế 500 - nhưng vẫn có thể in 1000 trong hàm
            //muốn cấm điều đó, tao đưa bao nhiêu , in báy nhiêu
        }
        //Truyền thái Y kiểu tham trị và tham chiếu

        //Nơi gọi gửi 1 biến , thực ra chỉ xin value
        static void DoSomething(int n)
        {
            //thay đổi trên N , thì chỉ làm thay đổi trong N, không ảnh hưởng đến cái biến mà từng đưa value cho N , không ảnh hưởng đến biến mà lúc gọi hàm này
            //=> truyền tham trị - Pass by value
            n = 6789;
            Console.WriteLine($"Value N in method: {n}");

        }
        //static void Main(string[] args)
        //{
        //    int x = 2024;
        //    DoSomething(x);
        //    Console.WriteLine($"x after calling method: {x}");
        //}

        static void DoSomethingV2(in int n)//truyền tham trị - pass by value
            // khiến tham số đầu vào thành readonly, chỉ được sài mà khôn được sữa
        {
            //Khi nào thì dùng in ;
            //Khi mình muốn giá trị được nhận vào, vô trong đây phải giữ nguyên giá trị bên trong, k được thay đổi
            //n = 6789;
            //n = 1000;

            //in các số từ 1 đến n
            Console.WriteLine("The list of number from 1 to " + n);
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            //sống có trách nhiệm, xuống dòng sau khi in xong
            Console.WriteLine();

        }

    }
}
//Đặt vấn đề:
//Trong câu lệnh SQL, có lệnh, thao tác trên table , có nhiều dòng,
//VD: TABle Student thì có nhiều dòng , mỗi dòng là 1 bạn sinh viên 
// Với các infor : ID, name , YOB, PalceOFBirth, Major, GPA....

//Ta có nhu cầu thống kê tính toán trên cái tập data nhiều nhiều này
//Ví dụ: tính xem hiện có bao nhiêu sinh viên quê ở Bình Dương
//      Tính xem hiện có bao nhiêu sv điểm TB >= 8
//      Tính xem hiện có bao nhiêu SV điểm TB < 5
//       Tính xem hiện có bao nhiêu SV điểm TB >=8 và Quê ở Bình Dương...
//Hãy tưởng tượng?
//Nếu làm 5 hàm => phí công duyệt FOR lại từ đầu cho mỗi hàm
//Tiếp cận kiểu mới: Duyệt for 1 lần hỏi 1 lần 5 câu luôn, trúng câu nào, ++câu đó lên, 
//Hàm xử lý và trả về nhiều hơn 1 giá trị, do đó công đi 1 lần tính luôn nhiều đại lượng
//Ta cần kĩ thuật giúp hàm trả về nhièu giá trị (mà không cần dùng mãng)
//Ta trả giá trị trả về qua ngõ/hẽm /ngã đường/ tham số paremeter của hàm
//hàm có thể nhận vầo vô số tham số , ta tả data qua hàm qua tham số !!
// Nếu làm được điều này, có vẽ giống câu:

//SELECT COUNT()  SUM()    AVERGE()   FROM TABLE .....
//CÙng 1 lần SELECT trong table , ta tính luôn vài giá trị.....
