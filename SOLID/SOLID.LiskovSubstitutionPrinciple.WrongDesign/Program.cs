using System;

namespace SOLID.LiskovSubstitutionPrinciple.WrongDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 5;
            rectangle.Width = 10;

            // square không thể thay thế rectangle
            // do vậy đây là một thiết kế sai
            Console.WriteLine("Square = "+ rectangle.CalculateSquare());
            Console.ReadLine();
        }
    }

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
}
