using System.Runtime.Intrinsics.X86;

namespace Bai3
{
    /*
     *Trong lập trình,toán tử là các kí hiệu được sử dụng để
     *đánh dấu các phép tính, biểu thức mà thông qua đó chương trình có thể
     *biên dịch và chạy được. Toán tử là thành phần thiết yếu bắt buộc phải có 
     *với mọi loại ngôn ngữ lập trình 
     *có nhiều cách để chúng ta phân loại toán tử
     *Chúng ta có thể phân loại toán thử qua chức năng:
     *-Số học( những toán tử được sử dụng để tính toán)
     *-logic(&& || !) thực hiện các nguyên lí logic
     *-Gán (=, +=, -=, *=, /=) gán giá trị
     *cũng có thể phân loại theo ngôi
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Khai báo 2 biến a và b kiểu số nguyên và thực hiện việc tính các phép
            // +, -, *, /, hai số đó cho nhau (kết quả phải chính xác)
            //xác định đầu ra là unicode
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Xác định đầu vào là unicode
            Console.InputEncoding = System.Text.Encoding.Unicode;

            //Console.WriteLine("Nhập số a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //console.WrireLine("Nhập số b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {a} + {b}");
            //Console.WriteLine($"{a} - {b} = {a} - {b}");
            //Console.WriteLine($"{a} * {b} = {a} * {b}");
            //Console.WriteLine($"{a} / {b} = {a * 1.0 / b}");

            //Khi ta thực hiện phép toán a*1.0 thì bản chất kết quả thu được là:
            //Một số thực(ép kiểu ngắn), kết quả a*1.0/b cũng vậy.

            //2.Thực hiện phép toán ++, --, *=, /=,
            //Với 2 biến X,Y kiểu doubke
            Console.WriteLine("Nhập số x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tăng x lên 1 đơn vị"++x);
            Console.WriteLine("Giảm y đi 1 đơn vị"--y);
            Console.WriteLine($"x và y sau khi tăng giảm 1 đơn vị là : {x},{y});
            //Lưu ý: Phép y-- hoặc x++ sẽ thực hiện việc thay đổi giá trị của 
            //X và Y sau khi câu lệnh chứa biểu thức này đã được thực thi
            //Còn phép --y/++x sẽ thực hiện tăng giá trị trước khi thực hiện lệnh in 
            //khi các câu lệnh được viết song song thì ưu tiên việc thực thi 
            //++x và --y trước X++ và Y--
            Console.WriteLine($"{x++} {++x}, {--x},{x--}, {--x}");
            //Làm quen mở rộng nó sẽ tính từ trái qua phải
            //Gán X=X/Y
            Console.WriteLine($"{x}Sau khi tăng {y} lần là: {x *= y}");
            // 3. Thực hiện phép
            // tính a*b với hàm pow sau đó thực hiện phép 
            // tính căn bậc a của b với hàm pow

            Console.WriteLine("Nhập a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập b :");
            double b = Convert.ToDouble(Console.ReadLine());
            //Áp dụng công thức căn bậc b của a = a^(1/b)
            Console.WriteLine($"{a}^{b}= {Math.Pow(a, 1/b)}");
            //Áp dụng công thức căn bậc b của a = a^(1^b)
            Console.WriteLine(Math.Log(6));
            Console.WriteLine(Math.Log10(1000));
            Console.WriteLine(Math.Log6(8));
        }
    }
}
