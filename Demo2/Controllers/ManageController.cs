using Demo2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class ManageController : Controller
    {
        
        // GET: Manage
        [HttpGet]
        public ActionResult AddBook()
        { return View(new BookViewModel());
        }
        [HttpPost]
        public ActionResult AddBook(BookViewModel book)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "AllahAkbar";
                return View(book);
            }
            else
            {
                _bookRepository.AddBook(book);
                return RedirectToAction("AddBook");                   
            }
        }
    }
}