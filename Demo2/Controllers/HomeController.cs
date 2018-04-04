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
        private CarRepository _carRepository = new CarRepository();
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

        public ActionResult Cars(int id)
        {
            if (id <= 0)
                id = 1;
            var model = new CarCategoryWithModels
            {
                CarBrand = _carRepository.GetCategories(),
                CarModel = _carRepository.GetCategoryById(id).Cars,
                CurrentCategory = id
            };

            return View(model);
        }

        public ActionResult CarDetails(int id)
        {
            var carModel = _carRepository.GetCarById(id);
            var carViewModel = new CarViewModel
            {
                Brand= carModel.Brand,
                Name = carModel.Name,
                Engine=carModel.Engine,
                ReleaseDate=carModel.ReleaseDate,
            };

            return View(carViewModel);
        }
    }
}