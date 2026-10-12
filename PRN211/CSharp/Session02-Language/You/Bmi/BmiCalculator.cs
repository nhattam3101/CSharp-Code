

namespace Bmi
{
    //làm document cho 1 thư viện = swaggerUI bên API, viết 1 cái hướng dẫn sử dụng
    /// <summary>
    /// Class này cung cấp các hàm để tính ra chỉ số BMI của một cá nhân bất kì dựa trên chiều cao và cân nặng, đồng thời bình luận mập ốm.
    /// </summary>

    public class BmiCalculator
    {
        //không cần nhớ của riêng ai thì dùng static
        //singleton
        //Quy ước đặt tênn hàm/method trong C#:
        //1. C# đặt tên hàm theo Verb + Object
        //và dùng cú pháp PascalCase Notation - chữ hoa từng đầu từ
        //vd: GetYob, GetName, Sqrt, GetSalary

        //Java cũng vậy nhma dùng cú pháp con lạc đà - camelCase Notation - chữ hoa từng đầu từ, chữ thường từ đầu tiên



        //Viết hàm theo style expression Body - luyện tập
        //viết hàm in ra chuỗi sau: bmi stands for body mass index - chỉ số khối của cơ thể - con số tính toán từ chiều cao và cân nặng
        public static void PrintBmiMessage() => Console.WriteLine("BMI stands for Body Mass Index - Chỉ số khối của cơ thể...");



        //static double GetBmi(double weight, double height) => weight / (height * height);
        //nếu hàm chỉ có duy nhất 1 câu lệnh, áp dụng kĩ thật chỉ còn cái dây nịt phiên bản 1, được quyền dẹp luôn cái return
        //C# cung cấp 1 kĩ thuật giúp rút gọn thân hàm khi hàm chỉ có duy nhất 1 câu lệnh, cho phép loại bỏ dấu {} của hàm
        //loại bỏ luôn cả từ khoá return
        //kết quả hàm chỉ còn lại cái dây nịt(v1): Tên hàm => thân hàm1
        //KĨ thuật này được gọi tên là: Expression Body, Expression Bodied
        //hàm có thân/code của hàm nhìn gọn gàng như biểu thức tính toán

        //Tuyệt đối k nhầm với chỉ còn cái dây nịt V2 - Kĩ thuật biểu thức Lambda - Lambda Expression cũng sài chung cái dấu
        //=> nhưng ý nghĩa hoàn toàn khác, cực kì vi diệu - học sau

        //Java cũng có nhưng là dấu : -> 

        //phiển bản tiếp theo
        /// <summary>
        /// Tính chỉ số BMI dựa trên cân nặng và chiều cao.
        /// </summary>
        /// <param name="weight">Cân nặng, đơn vị kg.</param>
        /// <param name="height">Chiều cao, đơn vị mét.</param>
        /// <returns>Chỉ số BMI.</returns>
        public static double GetBmi(double weight, double height)
            => weight / (height * height);


        //static double GetBmi(double weight, double height)
        //{//tiêu chuẩn để viết hàm thiết kế tốt, re-use ngon, giống 
        // //Math.Sqrt() Java Math.Sqrt() C#
        // //hàm nhận đầu voà và trả đầu ra!!!
        // //tiêu chuẩn hàm y == f(x^2)
        // //              y = f(5) = 25
        // //k có lệnh nhập và k có lệnh xuất là tốt nhất
        // //nhiệm vụ của hàm là tập trung vào xử lý

        //    return weight / (height * height);
        //}

    }
}
