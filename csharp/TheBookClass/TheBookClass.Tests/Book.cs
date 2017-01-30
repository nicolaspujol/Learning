using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheBookClass.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void DisplayBookData()
        {
            Book book = new Book("title", "author", 10);

            Assert.AreEqual("Title: title, Author: author, Price: 10", book.DisplayBookData());
        }
    }
}
