using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class Helper
    {
        
        public static string path = "D:/Demo.json";
        public static string Path { get => path; set => path = value; }


        public static List<Book> books = new List<Book>();
        public static List<Book> Data { get => books; set => books = value; }
        public static List<Book> linqSorted = new List<Book>();
        public static List<Book> LinqSortedBooks { get => linqSorted; set => linqSorted = value; }




        public static void AddBook(Book book)
        {
            for (var i = 0; i < books.Count; i++)
            {
                if (books[i].Code == book.Code)
                {
                    throw new Exception("Book with entered ID alreadt exists.");
                    break;
                }
            }
            books.Add(book);
        }
        public static void ChangeBookById(Book book)
        {
            
            for (var i = 0; i < books.Count; i++)
            {
                if (books[i].Code == book.Code)
                {
                    books[i].Title = book.Title;
                    books[i].Author = book.Author;
                    books[i].Publish_year = book.Publish_year;
                    books[i].Edition = book.Edition;
                    books[i].Price = book.Price;
                    books[i].Amount = book.Amount;
                    break;
                }
                else 
                {
                    throw new Exception("No element was found by the entered code.");
                }
            }
        }


        public static void DeleteByCode(int code)
        {
            for (var i = 0; i < books.Count; i++)
            {
                if (books[i].Code == code)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }




        

        public static Book CheckInput(string code, string title, string author, string publish_year, string edition, string price, string amount)
        {
            int _code;
            int _publish_year;
            double _price;
            int _amount;
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publish_year)
                || string.IsNullOrEmpty(edition) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(amount))
            {
                throw new Exception("Empty fields are not allowed");
            }
            else if (!int.TryParse(code, out _code))
            {
                throw new Exception("Code must be of type int");
            }
            else if (!int.TryParse(publish_year, out _publish_year))
            {
                throw new Exception("Publish_year must be of type int");
            }
            else if (!double.TryParse(price, NumberStyles.Any, CultureInfo.InvariantCulture,out _price)) 
            {
                throw new Exception("Price must be of type double");
            }
            else if (!int.TryParse(amount, out _amount))
            {
                throw new Exception("Amount must be of type int");
            }
            return new Book(_code, title,  author, _publish_year, edition,  _price,  _amount);
        }





        public static IEnumerable<Book> FilterByProducer(String author, List<Book> input)
        {
            return from l in input where l.Author.Equals(author) select l;
        }

        public static IEnumerable<Book> FilterByYear(int year, List<Book> input)
        {
            return from l in input where l.Publish_year == year select l;
        }
        public static IEnumerable<Book> FilterByModel(String edition, List<Book> input)
        {
            return from l in input where l.Edition.Equals(edition) select l;
        }
    }
}
