using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS411_Project.dal.Repositories;
using CIS411_Project.Core.Models;
using CIS411_Project.dal;

namespace CIS411_Project.Tests.dal
{
    [TestClass]
    public class BookTest
    {
        private BookRepo repo = null;
        private BOOK book = null;
        private BOOK testBook = null;

        [TestInitialize]
        public void bookSetup()
        {
            repo = new BookRepo();
            testBook = new BOOK();
            DateTime dt = DateTime.Now;
            long a = dt.Ticks;


            testBook = new BOOK();
            testBook.BOOK_ID = 1;
            testBook.BOOK_TITLE = "Fundamentals of Human Resource Management";
            testBook.BOOK_EDITION = 10;
            testBook.BOOK_DESC = "An intorduction to Human Resource Management";
            testBook.BOOK_PUBLISHER = "New York";
            testBook.BOOK_AUTHOR = "David A. Decenzo";
            testBook.BOOK_PRICE = 25;
            testBook.CATEGORY_ID = 1;
            testBook.CONDITION_ID = 1;
            testBook.USER_ID = 1;
            testBook.CREATED_TIMESTAMP = BitConverter.GetBytes(a);
            repo.add(testBook);

            testBook = new BOOK();
            testBook.BOOK_ID = 2;
            testBook.BOOK_TITLE = "Algebra";
            testBook.BOOK_EDITION = 8;
            testBook.BOOK_DESC = "A Graphical approach to Algebra";
            testBook.BOOK_PUBLISHER = "New York";
            testBook.BOOK_AUTHOR = "Stephen P. Robbins";
            testBook.BOOK_PRICE = 28;
            testBook.CATEGORY_ID = 1;
            testBook.CONDITION_ID = 1;
            testBook.USER_ID = 1;
            testBook.CREATED_TIMESTAMP = BitConverter.GetBytes(a);
            repo.add(testBook);
        }
        [TestMethod]
        public void bookTest()
        {
            book = repo.getById(new BOOK { BOOK_ID = 1 });
            Assert.AreEqual(testBook.BOOK_TITLE, book.BOOK_TITLE);

            book.BOOK_TITLE = "Test Book Title";
            repo.update(book);

            testBook = repo.getById(new BOOK { BOOK_ID = 1 });
            Assert.AreEqual(testBook.BOOK_TITLE, book.BOOK_TITLE);

            book.BOOK_TITLE = "Another Test Title";
            repo.update(book);

            IEnumerable<BOOK> results = (IEnumerable<BOOK>)repo.query(t => t.BOOK_ID == book.BOOK_ID);
            foreach (BOOK p in results)
            {
                if (p.BOOK_ID == book.BOOK_ID)
                {
                    Assert.AreEqual(testBook.BOOK_TITLE, book.BOOK_TITLE);
                }
            }
        }
        [TestCleanup]
        public void cleanUp()
        {
            book = repo.getById(new BOOK { BOOK_ID = 1 });
            repo.remove(book);
            book = repo.getById(new BOOK { BOOK_ID = 1 });
            Assert.AreEqual(null, book);
            book = repo.getById(new BOOK { BOOK_ID = 2 });
            repo.remove(book);
            book = repo.getById(new BOOK { BOOK_ID = 2 });
            Assert.AreEqual(null, book);
        }
    }
}
