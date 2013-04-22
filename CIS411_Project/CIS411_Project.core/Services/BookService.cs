﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS411_Project.Core.Models;
using CIS411_Project.dal;
using CIS411_Project.dal.Repositories;

namespace CIS411_Project.Core.Services
{
    public class BookService : CIS411_Project.Core.Services.IService
    {
        /*
         * books = book class
         * BOOK  = Book Table
        */
        public ICollection<Books> listBooksByUser(int userId)
        {
            BookRepo BookRepo = new BookRepo();
            IEnumerable<BOOK> books = BookRepo.query(p => p.USER_ID == userId);

            ICollection<Books> bookList = new List<Books>();
            Books book = null;
            foreach (BOOK b1 in books)
            {
                book = new Books();
                book.BOOK_ID = b1.BOOK_ID;
                book.BOOK_TITLE = b1.BOOK_TITLE;
                book.BOOK_DESC = b1.BOOK_DESC;
                book.USER_ID = userId;
                book.BOOK_AUTHOR = b1.BOOK_AUTHOR;
                book.BOOK_EDITION = b1.BOOK_EDITION;
                book.BOOK_PRICE = b1.BOOK_PRICE;
                book.BOOK_PUBLISHER = b1.BOOK_PUBLISHER;
                book.CATEGORY_ID = b1.CATEGORY_ID;
                book.CONDITION_ID = b1.CONDITION_ID;
                book.CREATED_TIMESTAMP = b1.CREATED_TIMESTAMP;

                bookList.Add(book);
            }
            BookRepo = null;
            return bookList;
        }

        public ICollection<Books> listBooks()
        {
            BookRepo BookRepo = new BookRepo();
            IEnumerable<BOOK> books = BookRepo.getAll();

            ICollection<Books> bookList = new List<Books>();
            Books book = null;
            foreach (BOOK b2 in books)
            {
                book = new Books();
                book.BOOK_ID = b2.BOOK_ID;
                book.BOOK_TITLE = b2.BOOK_TITLE;
                book.BOOK_DESC = b2.BOOK_DESC;
                book.USER_ID = b2.USER_ID;
                book.BOOK_AUTHOR = b2.BOOK_AUTHOR;
                book.BOOK_EDITION = b2.BOOK_EDITION;
                book.BOOK_PRICE = b2.BOOK_PRICE;
                book.BOOK_PUBLISHER = b2.BOOK_PUBLISHER;
                book.CATEGORY_ID = b2.CATEGORY_ID;
                book.CONDITION_ID = b2.CONDITION_ID;
                book.CREATED_TIMESTAMP = b2.CREATED_TIMESTAMP;

                bookList.Add(book);
            }
            BookRepo = null;
            return bookList;
        }


        public Books getBookById(int bookId)
        {
            BookRepo bookRepo = new BookRepo();
            BOOK b3 = bookRepo.getById(new BOOK { BOOK_ID = bookId });
            Books book = new Books();
            book.BOOK_ID = b3.BOOK_ID;
            book.BOOK_TITLE = b3.BOOK_TITLE;
            book.BOOK_DESC = b3.BOOK_DESC;
            book.USER_ID = b3.USER_ID;
            book.BOOK_AUTHOR = b3.BOOK_AUTHOR;
            book.BOOK_EDITION = b3.BOOK_EDITION;
            book.BOOK_PRICE = b3.BOOK_PRICE;
            book.BOOK_PUBLISHER = b3.BOOK_PUBLISHER;
            book.CATEGORY_ID = b3.CATEGORY_ID;
            book.CONDITION_ID = b3.CONDITION_ID;
            book.CREATED_TIMESTAMP = b3.CREATED_TIMESTAMP;

            return book;
        }

        public User insertUser(User newUser)
        {
            User user2add = newUser;
            USER u3 = null;
            UserRepo userRepo = new UserRepo();
          

            u3.USER_FNAME = newUser.USER_FNAME;
            u3.USER_LNAME = newUser.USER_LNAME;
            u3.USER_EMAIL = newUser.EMAIL;
            u3.USER_DISPLAYNAME = newUser.USER_DISPLAYNAME;
            u3.PASSWORD = newUser.PASSWORD;
            u3.CREATED_TIMESTAMP = DateTime.Now;
            userRepo.add(u3);


            return newUser;
        }



    }
}
