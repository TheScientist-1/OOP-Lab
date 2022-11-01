using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

public class Book
{
    [JsonIgnore] // параметр PublishingHouseId не серіалізуватиметься
    public int PublishingHouseId { get; set; }
    [JsonPropertyName("Name")] // серіалізований об’єкт міститиме параметр Title з назвою “Name” 
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }

    public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
    {
        PublishingHouseId = publishingHouseId;
        Title = title;
        PublishingHouse = publishingHouse;
    }
}
public class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public PublishingHouse(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}

public class Test
{
    static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string path1 = @"C:\Users\m\Desktop\sample.json";  //File.ReadAllLinesAsync(path)
        using (FileStream fs = new FileStream(path1, FileMode.Open))
        {
            var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);
            foreach (var item in books)
            {
                Console.WriteLine($"{item.PublishingHouseId} - {item.Title} - {item.PublishingHouse.Id} -{item.PublishingHouse.Name} - {item.PublishingHouse.Address} ");
            }
        }
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        var book1 = new Book(3, "Logic", new PublishingHouse(1,"MathPublisher","Address"));
        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(book1, options));

        Console.ReadKey();
    }
}