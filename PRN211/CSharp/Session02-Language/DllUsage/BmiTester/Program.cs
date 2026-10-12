using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.sqrt ()
            //Math.Sqrt() cùng style nhận trả ra
            var bmi = BmiCalculator.GetBmi(70, 1.7);
            //typr inferent - ngầm suy luận ra data type
            Console.WriteLine("BMI(70kg- 1m7): " + bmi);
            Console.WriteLine("BMI(70kg- 1m7): {0}", bmi);
            Console.WriteLine($"BMI(70kg- 1m7): {bmi} ");
            Console.WriteLine($@"BMI(70kg- 1m7): {bmi}");
            string bmiMessage =$"BMI(70kg- 1m7): {bmi}";
            //ở đâu có dấu = thì dùng a hay b cùng như nhao
            Console.WriteLine(bmiMessage);
            Console.WriteLine($"BMI(70kg- 1m7): {BmiCalculator.GetBmi(70, 1.7)}");
        }
    }
}
//DLL - Dynamic Link Library - Thư viện package, thư mục folder, namespace
//chứa bên trong nhiều class, method, cũng cấp tiện ích cho dân dev làm việc gì đó chẳng hạn. .DLL để quản lý camera, .dll để móc xuóng database, .dll để truyền massage qua.

//DLL nó không phải là file nhị phân - Binary code mà là code/mã trung tính trung gian không gắn với 1 OS cụ thể, nó chạy chơi với Runtime, runtime chơi vối OS

//APP chạy đa nền/platform independent, cross-platform bản chất là phải có thằng runtime gắn với os/nền cụ thể
//app chỉ chơi với thằng runtime 
//app chỉ chơi với thằng runtime - macOs
                                //-Linux
                                //window

//app trung tính - code trung tính này gọi là MSIL Language, IL
//                                              Microsoft Intermidate language
//Từ MSIL -> back ngược lại .CS src code gốc dev viết ra
//          reverse engineering - dịch ngược về src code 
//          de-compiler
//DOTPEEK là một trong những tool giúp suy ngược lại code
//Từ Msil lúc run thì biến thành Machine code - binary code thật gắn vối Os
//                              Chỉ dùng ngôn ngữ lập trình cấp thấp
//Assembly để coi