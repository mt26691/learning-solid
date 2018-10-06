using System;

namespace SOLID.LiskovSubstitutionPrinciple.WrongDesign
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateSquare()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public int Side { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 5;
            rectangle.Width = 10;

            // Nếu Square kế thừa từ Rectangle, thì Square phải là một kiểu của Rectangle.
            // Khi thay thế Rectangle bằng class Square sẽ cho kết quả sai nếu muốn tính toán diện tích hình vuông.
            // Vì thế Square không thể thay thế Rectangle trong trường hợp này. 
            // Thiết kế này vi phạm nguyên tắc LSP.
            Console.WriteLine("Square = " + rectangle.CalculateSquare());
            Console.ReadLine();
        }
    }
}
