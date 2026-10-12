namespace FunctionOut
{
    //CHALLANGE #1: kiểm tra keyword out ảnh hưởng như thế nào biến gốc , truyền vào hàm
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2004;
            Console.WriteLine($"Value of n calling method: {n}");
            DoSomething(out n);
            Console.WriteLine($"Value of n after calling method: {n}");
        }

        static void DoSomething(out int n)
        {
            n = 6789;
            Console.WriteLine($"Value of n in method: {n}");
        }
    }
}
