using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab4
{
    internal class JsonMaster
    {
        private JsonMaster() { }

        public static List<Book> DeserialiseFromJson(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return JsonSerializer.Deserialize<List<Book>>(fs);
            }
        }

        public static void SerializeToJson(String path, List<Book> books)
        {
            var options = new JsonSerializerOptions {WriteIndented = true};
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, books, options);
            }
        }
    }
}
