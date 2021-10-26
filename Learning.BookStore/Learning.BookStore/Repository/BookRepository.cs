using Learning.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Santanu"},
                new BookModel(){Id=2, Title="Microsoft", Author="Microsoft"},
                new BookModel(){Id=3, Title="Java", Author="Santanu"},
                new BookModel(){Id=4, Title="PHP", Author="Rahul"},
                new BookModel(){Id=5, Title="Mac OS", Author="Santanu"},
                new BookModel(){Id=6, Title="Linux", Author="Linux"},
            };
        }
    }
}
