using System;
//В програмі було порушено принцип Лісков
//Виправимо:
namespace Task3
{
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }
    
    class Square 
    {
        public int Size
        {
            get { return Size; }
            set { }
        }
        public int GetSquareArea()
        {
            return Size * Size;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();
                rect.Width = 5;
                rect.Height = 10;

                Console.WriteLine(rect.GetRectangleArea());
                Console.ReadKey();
            }
        }

    }
}