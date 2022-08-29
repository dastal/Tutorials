using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course.Classes
{
    class NextGenBook
    {
        public string title;
        public string author;
        public int pages;

        public NextGenBook()
        {

        }

        public NextGenBook(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Book created");
            Console.WriteLine("Title: " + aTitle);
            Console.WriteLine("Author: " + aAuthor);
            Console.WriteLine("Pages: " + aPages);
            Console.WriteLine();
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
