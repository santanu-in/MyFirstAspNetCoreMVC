using Learning.BookStore.Models;
using Learning.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.BookStore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly BookRepository _bookrepository = null;

        public BookController()
        {
            _bookrepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookrepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookrepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookrepository.SearchBooks(bookName, authorName);
        }
    }
}
