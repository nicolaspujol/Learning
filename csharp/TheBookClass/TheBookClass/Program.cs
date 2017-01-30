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
            for (int i = 1; i <= 2; i++) {
                Console.WriteLine("Book " + i + ":");
                Book book = AddBook();
                Console.WriteLine(book.DisplayBookData());
            }
            Console.ReadKey();
        }

        private static Book AddBook()
        {
            string bookTitle = GetBookData("Title");
            string bookAuthor = GetBookData("Author");
            double bookPrice = double.Parse(GetBookData("Price"));

            return new Book(bookTitle, bookAuthor, bookPrice);
        }

        private static string GetBookData(string expectedData)
        {
            Console.WriteLine($"{expectedData}?");
            return Console.ReadLine();
        }
    }
}
