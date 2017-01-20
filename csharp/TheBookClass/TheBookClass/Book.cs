using System;

namespace TheBookClass
{
    public class Book
    {
        private string _title;
        private string _author;
        private double _price;

        public Book(string title, string author, double price) {
            this._title = title;
            this._author = author;
            this._price = price;
        }

        public string DisplayBookData() {
            return $"Title: {_title}, Author: {_author}, Price: {_price}";
        }
    }
}
