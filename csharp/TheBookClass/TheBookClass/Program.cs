using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++) {
                Book book = AddBook();
                book.DisplayBookData();
            }
        }

        private static Book AddBook()
        {
            string bookTitle = getBookData("Title");
            string bookAuthor = getBookData("Author");
            string bookPrice = getBookData("Price");

            return new Book(bookTitle, bookAuthor, bookPrice);
        }

        private static string getBookData(string expectedData)
        {
            Console.WriteLine($"{expectedData}:");
            return Console.ReadLine();
        }
    }
}
