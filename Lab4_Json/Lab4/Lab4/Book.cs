namespace Lab4
{
    public class Book
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Publish_year { get; set; }
        public string Edition { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }


        public Book(int code, string title, string author, int publish_year, string edition, double price, int amount)
        {
            Code = code;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            Publish_year = publish_year;
            Edition = edition ?? throw new ArgumentNullException(nameof(edition));
            Price = price;
            Amount = amount;
        }
    }
}
