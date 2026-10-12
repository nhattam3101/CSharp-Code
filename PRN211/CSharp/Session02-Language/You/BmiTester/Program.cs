using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double bmi = BmiCalculator.GetBmi(70, 1.7);
            var bmi = BmiCalculator.GetBmi(70, 1.7);
            //var: làm biếng khai báo biến data type
            //nhưng phải gán giá trị ngay cho cho biến k xác định kiểu data ngay khi khai báo!!!
            //biến mang data type là value được gán vào
            //bmi chính là double, do value đưa vào nó là double

            //bmi = "ahihihi";
            //type inferent: suy luận ngầm hiểu data type của 1 biến

            //concatetion
            Console.WriteLine("BMI(70, 1m7): " + bmi);
            //placeholder
            Console.WriteLine("BMI(70, 1m7): {0}", bmi);
            //interpolation
            Console.WriteLine($"BMI(70, 1m7): {bmi}");

            Console.WriteLine($"BMI(70, 1m7): {BmiCalculator.GetBmi(70, 1.7)}");
        }
    }
}
