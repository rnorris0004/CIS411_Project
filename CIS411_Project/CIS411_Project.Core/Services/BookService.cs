using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS411_Project.Core.Models;
using CIS411_Project.dal;
using CIS411_Project.dal.Repositories;

namespace CIS411_Project.Core.Services
{
    public interface BookService : CIS411_Project.Core.Services.IService
    {
        /*
         * books = book class
         * BOOK  = Book Table
        */
        public ICollection<Books> listBooksByUser(int userId){
            BookRepo BookRepo = new BookRepo();
            IEnumerable<BOOK> booksByUser = BookRepo.query(p => p.USER_ID == userId);

            ICollection<Books> books = new List<Books>();
            Books book = null;
            foreach (BOOK p1 in books)
            {
                book = new Books();
                book.BOOK_ID = p1.BOOK_ID;
                book.BOOK_TITLE = p1.BOOK_TITLE;
                book.BOOK_DESC = p1.BOOK_DESC;
                book.USER_ID = userId;
                book.BOOK_AUTHOR = p1.BOOK_AUTHOR;
                book.BOOK_EDITION = p1.BOOK_EDITION;
                book.BOOK_PRICE = p1.BOOK_PRICE;
                book.BOOK_PUBLISHER = p1.BOOK_PUBLISHER;
                book.CATEGORY_ID = p1.CATEGORY_ID;
                book.CONDITION_ID = p1.CONDITION_ID;
                book.CREATED_TIMESTAMP = p1.CREATED_TIMESTAMP;
                
                books.Add(book);
            }
            BookRepo = null;
            return books;
        }

        public ICollection<Books> listBooks()
        {
            BookRepo BookRepo = new BookRepo();
            IEnumerable<Books> books = BookRepo.getAll();

            ICollection<Books> phoneModels = new List<Books>();
            Books phoneModel = null;
            foreach (Phone phoneData in phones)
            {
                phoneModel = new PhoneModel();
                phoneModel.phoneCd = phoneData.PHONE_CD;
                phoneModel.phoneNumber = phoneData.PHONE_TX;
                phoneModel.lastModifiedDate = phoneData.MOD_DT;
                phoneModel.applicantId = phoneData.APPLICANT_ID;
                phoneModel.createDate = phoneData.CREATE_DT;
                phoneModel.phoneId = phoneData.PHONE_ID;

                phoneModels.Add(phoneModel);
            }
            phoneRepo = null;
            return phoneModels;
        }


        public PhoneModel getPhoneById(decimal phoneId)
        {
            PhoneRepo phoneRepo = new PhoneRepo();
            Phone phoneData = phoneRepo.getById(new Phone{PHONE_ID=phoneId});
            PhoneModel phoneModel = new PhoneModel();
            phoneModel.phoneId = phoneData.PHONE_ID;
            phoneModel.applicantId = phoneData.APPLICANT_ID;
            phoneModel.createDate = phoneData.CREATE_DT;
            phoneModel.lastModifiedDate = phoneData.MOD_DT;
            phoneModel.phoneCd = phoneData.PHONE_CD;
            phoneModel.phoneNumber = phoneData.PHONE_TX;

            return phoneModel;
        }




        public ICollection<PhoneCodeModel> getPhoneCds()
        {
            ICollection<PhoneCodeModel> codeModels = new List<PhoneCodeModel>();

            PhoneCodeRepo repo = new PhoneCodeRepo();
            PhoneCD[] codes = repo.getAll();
            foreach (PhoneCD codeData in codes)
            {
                PhoneCodeModel codeModel = new PhoneCodeModel();
                codeModel.lastModifiedDate = codeData.MOD_DT;
                codeModel.phoneCode = codeData.PHONE_CD;
                codeModel.phoneCodeDescription = codeData.PHONE_TX;
                codeModels.Add(codeModel);
            }
            return codeModels;
        }
    }
}
