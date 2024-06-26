using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SearchResult
    {
        public string Book { get; set; }
        public string Parasha { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }

        public SearchResult(string book, string parasha, string chapter, string verse)
        {
            Book = book;
            Parasha = parasha;
            Chapter = chapter;
            Verse = verse;
        }
        public override string ToString()
        {
            return "Book: " + Book + " Parasha: " + Parasha + " Chapter: " + Chapter + " Verse: " + Verse;
        }
    }
}
