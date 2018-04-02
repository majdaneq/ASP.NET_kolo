using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo2.DataAccessLayer;
using Demo2.ViewModels;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        
        private BooksRepository _booksRepository = new BooksRepository();
        // GET: Home
        public ActionResult Index(int id)
        {            
            if (id <= 0)
                id = 1;
            var model = new CategoriesWithBooks
            {
                Books = _booksRepository.GetCategoryById(id).Books,
                Categories = _booksRepository.GetCategories(),
                CurrentCategory = id
            };

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var bookModel = _booksRepository.GetBookById(id);
            var bookViewModel = new BookViewModel
            {
                Author = bookModel.Author,
                CategoryName = bookModel.CategoryModel.Name,
                Title = bookModel.Title,
                Isbn = bookModel.Isbn,
                ContactEmail=bookModel.ContactEmail
            };

            return View(bookViewModel);
        }
    }
}