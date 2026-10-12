using System.ComponentModel;

namespace FunctionOutV2
{
    internal class Program
    {
        //CHALLANGE #1: Viết hàm trả về tổng cách số chẵn từ 1 cho đến 10, sum từ 1 - 10 luôn, số lượng các số chẵn từ 1 đến 10 , số lượng các sô lẽ
        static void Main(string[] args)
        {
            int sumEvens;
            int countEvens;
            int sumOdds;
            int countOdds;
            int sumAll = ComputeOnNumber(out sumEvens, out countEvens, out sumOdds, out countOdds);

            Console.WriteLine($"SumAll: {sumAll} | SumEvens: {sumEvens} | CountEvens: {countEvens} | SumOdds: {sumOdds} | CountOdds: {countOdds} ");
        }

        static int ComputeOnNumber(out int sumEvens, out int countEvens, out int sumOdds, out int countOdds)
        {
            sumEvens = 0;
            countEvens = 0;
            sumOdds = 0;
            countOdds = 0;
            int sumAll = 0;//biến dành cho return đườnh chính đạo
            //1 lần duyệt for hỏi đủ các câu thay vì nhiều for
            for (int i = 1; i <= 10; i++)
            {
                //gặp bắt i là suum 
                sumAll += i;
                if(i % 2 == 0)
                {
                    sumEvens += i;
                    countEvens++;
                }
                else
                {
                    sumOdds += i;
                    countOdds++;
                }
            }

            return sumAll;
        }
    }
}


//CHALLANGE: Với tham số có từ khoá là "in" nghĩa là khiến cho biến đầu vào không thể thay đổi được value, nó nhận bên ngoài bao nhiêu, giờ trogn hàm giữ nguyên giá trị
//vd: void F(in int x,...) trong hàm F cấm thay đổi  giá trị của x khi một x được nhận value khi gọi hàm và truyền "giá trị"
// F(100) => x = 100 và mãi là 100 trong hàm; x đổi value khác lỗi error code ngay và luôn
//* Vậy nếu in đi kèm với bién object 
//vd : void F(in Student x)
//thì x lúc này có được quyền thay đổi cái gì quanh x hay không???
//vững oop thì sẽ trả lời được!!! X thật sự được thay đổi cái gì hay không