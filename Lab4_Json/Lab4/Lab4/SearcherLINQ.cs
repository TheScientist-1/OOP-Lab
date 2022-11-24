using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class SearcherLINQ
    {
        private SearcherLINQ() { }

        public static IEnumerable<Book> SearchByAuthor(string author, List<Book> input)
        {
            return from l in input where l.Author.Equals(author) select l;
        }

        public static IEnumerable<Book> SearchByYear(int year, List<Book> input)
        {
            return from l in input where l.Publish_year == year select l;
        }
        public static IEnumerable<Book> SearchByEdition(string edition, List<Book> input)
        {
            return from l in input where l.Edition.Equals(edition) select l;
        }
    }
}
