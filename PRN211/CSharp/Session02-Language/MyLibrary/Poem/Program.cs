using Poem.XuanQuynh;// tương đươncg import bên JAVA


namespace Poem
{
    internal class Program
    {
        //instance variable
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.UnicodeEncoding.Unicode;
            Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;

            Console.WriteLine("Hello, World!");

            //PrintTuAy();
            //UserVerbatim();
            Song.PrintSongCode();
        }
        //có câu: static chơi với static

        static void UserVerbatim()
        {
            //ứng dụng của verbatim
            /*string filePath = "C:\\SU26\\news";*///nháy đôi \\ lên thì k báo lõi nữa
            string filePath = @"C:\SU26\news";
            Console.WriteLine($@"Path: {filePath}\");
            //dùng trong các đường dẫn tên tập tin khi có các kí tự đặc biệt liên quan đến
            //giúp cho cái chuỗi tự nhiên như bản gốc!!
            //đuôi khi verbatim còn dùng trong chuỗi URL,
            //connection string : chuỗi kết nối CSDL có thông tin về server \ hay /

            //Verbatim có thể dùng kết hợp luôn với $ interpolation
            string filePath1 = @"E:\";
            Console.WriteLine(@$"Path: {filePath}\{filePath1}");
        }
        static void PrintTuAy()
        {
            int year = 2026;// khai báo biến dùng cú pháp con lạc đà camelCase Notation

            int month = 10;
            Console.WriteLine("YEAR: " + year + " | " + month); //ghép chuỗi style truyền thống
            //string concattenated dùng dấu +
            Console.WriteLine("YEAR: {0} | {1}", year, month);//placeholder
                                                //nếu in nhiều biến {0}, {1}, {2}...
                                                //các biến cách nhau bằng dấu phẩy
            Console.WriteLine($"YEAR: {year} | {month}"); //interpolation - nội suy giá trị biến trong chuỗi - cách này sẽ hay, tự nhiên trong việc viết chuỗi
                                                          //dấu $ được dùng để giúp các dấu {} để nội suy ra biến được ghi bên trong
                                                          //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");
                                                          //Console.WriteLine("Mặt trời chân lý trói qua tim");
                                                          //Console.WriteLine("Hồn tôi là một vườn hoa lá");
                                                          //Console.WriteLine("Rất rộn hương và rộn tiếng chim");

            //ctrl K C là comment 1 đám code, java: ctrl /
            // crtl k u là uncomment mở code ra 

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ\nMặt trời chân lý trói qua tim\nHồn tôi là một vườn hoa lá\nRất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"TỪ ẤY

Từ ấy trong tôi bừng nắng hạ
Mặt trời chân lý trói qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim");// @ sẽ biến chuỗi thành chuỗi nguyên bản, có ký tự gì bên trong chuỗi
            // lúc edit sẽ in i chang, có \n thi in \n luôn
            //phế võ công tất cả các ký tự đặc biệt thành ký tự bth
            //kĩ thuật chuỗi này gọi là verbatim


        }
    }
}
