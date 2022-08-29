using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class usningClassesAndMethods
    {
        static void ClassesAndMethods(string[] args)
        {
            // this Program requires the class "Book"

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine();

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.WriteLine();

            book1.pages = 500;
            Console.WriteLine(book1.pages);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
