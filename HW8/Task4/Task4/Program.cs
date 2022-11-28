using System;
//Було порушено принцип розділення інтерфейсу
//Виправимо:
namespace Task4
{
    interface IItemPrice
    {
        void SetPrice(double price);
    }
    interface IItemDiscount
    {
        void ApplyDiscount(String discount);
    }
    interface IItemPromocode
    {
        void ApplyPromocode(String promocode);
    }
    interface IItemColour
    {
        void SetColor(byte color);
    }
    interface IItemSize
    {
        void SetSize(byte size);
    }
    
    class Book : IItemPrice, IItemDiscount
    {
        private double price;
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void ApplyDiscount(String discount)
        {
            Console.WriteLine(discount);
        }
    }
    class Coat : IItemPrice, IItemDiscount, IItemColour, IItemSize
    {
        private double price;
        private byte size;
        private byte color;
        public void SetPrice(double price)
        {
            this.price = price * 2;
        }
        public void ApplyDiscount(String discount)
        {
            Console.WriteLine(discount);
        }
        public void SetSize(byte size)
        {
            this.size = size;
        }
        public void SetColor(byte color)
        {
            this.color = color;
        }

    }
    class Program
    {
        static void Main(string[] args)
        { }

    }
}