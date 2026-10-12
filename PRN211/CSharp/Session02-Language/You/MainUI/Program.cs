namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetBmi();
            
        }

        //CHALLENGE 1: VIẾT HÀM TÍNH CHỈ SỐ VÀ IN RA SỐ 
        //BMI - CHỈ SỐ KHỐI LƯỢNG CƠ THỂ - BODY MASS INDEX
        //NÓI VỀ TÌNH TRẠNG MẬP ỐM CỦA AI ĐÓ DỰA TRÊN
        //CHIỀU CAO VÀ CÂN NẶNG
        //BMI = CÂN NẶNG / BÌNH PHƯƠNG CHIỀU CAO (M)
        //NẾU BMI TỪ 18.5 - 24.9 LÀ CHUẨN FORM

        //static chơi với static 
        static void GetBmi()
        {
            double weight = 70;//kg
            double height = 1.7; //m

            double bmi = weight / (height * height);//
            Console.WriteLine($"BMI(w: {weight} - h: {height}): {bmi}");
            Console.WriteLine("BMI(w: {0} - h: {1}): {2}", weight, height, bmi);

        }
        //hàm phải thiết kế làm sao giống như y = f(x^2)
        // mình quăng vô cho nó 1 cái gì đó, rồi nó trả mình lại 1 cái gì đó, chứ ỉn ra luôn thì chưa hay
        //Mình muốn làm 1 cái mà cho nhiều thằng có thể sử dụng và gọi luôn chứ k bắt buộc phải là thg main ở program, thì mình làm 
        //Library: thằng này vẫn có các class chỉ khác là nó k có hàm main

    }
    //code viết đây là ăn đòn
    //nằm lơ lửng ở namespace

}
