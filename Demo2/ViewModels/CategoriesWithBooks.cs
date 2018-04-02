using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo2.Models;

namespace Demo2.ViewModels
{
    public class CategoriesWithBooks
    {
        public List<CategoryModel> Categories { get; set; }
        public List<BookModel> Books { get; set; }
    }
}