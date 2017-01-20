using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookClass
{
    class Book
    {
        private string _title;
        private string _author;
        private string _price;

        public Book(string title, string author, string price) {
            this._title = title;
            this._author = author;
            this._price = price;
        }

        public void DisplayBookData() {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Price: {_price}");
        }
    }
}
